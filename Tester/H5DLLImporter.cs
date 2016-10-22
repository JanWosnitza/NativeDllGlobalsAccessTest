using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using hid_t = System.Int64;

/// <summary>
/// Helper class used to fetch public variables (e.g. native type values)
/// exported by the HDF5 DLL
/// </summary>
internal abstract class H5DLLImporter
{
    public T Read<T>(string varName)
    {
        var address = this.GetAddress(varName);
        return (T) Marshal.PtrToStructure(address, typeof(T));
    }

    public hid_t ReadHid(string varName)
    {
        var address = this.GetAddress(varName);
        return Marshal.ReadInt64(address);
    }

    protected abstract IntPtr GetAddress(string varName);

    internal static H5DLLImporter Create(string libName)
    {
        switch ( Environment.OSVersion.Platform )
        {
            case PlatformID.Win32NT:
            case PlatformID.Win32S:
            case PlatformID.Win32Windows:
            case PlatformID.WinCE:
                return new H5WindowsDLLImporter(libName);
            case PlatformID.Xbox:
            case PlatformID.MacOSX:
            case PlatformID.Unix:
                return new H5UnixDllImporter(libName);
            default:
                break;
        }
        throw new NotImplementedException();
    }
}

internal class H5WindowsDLLImporter : H5DLLImporter
{
    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern IntPtr LoadLibrary(string lpszLib);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern IntPtr GetModuleHandle(string lpszLib);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool SetDllDirectory(string lpPathName);

    private IntPtr hLib;

    public H5WindowsDLLImporter(string libname)
    {
        var dir = Path.GetDirectoryName(typeof(H5WindowsDLLImporter).Assembly.Location);
        var bin = Environment.Is64BitProcess ? "bin64" : "bin32";
        SetDllDirectory(Path.Combine(dir, bin));

        this.hLib = GetModuleHandle(libname);
        if ( this.hLib == IntPtr.Zero )
        {
            this.hLib = LoadLibrary(libname);
            if ( this.hLib == IntPtr.Zero )
                throw new Exception($"Could not load library: {Marshal.GetLastWin32Error()}");
        }
    }

    protected override IntPtr GetAddress(string varName)
    => GetProcAddress(hLib, varName);
}

internal class H5UnixDllImporter : H5DLLImporter
{
    const int RTLD_NOW = 2; // for dlopen's flags

    [DllImport("libdl.so")]
    protected static extern IntPtr dlopen(string filename, int flags);

    [DllImport("libdl.so")]
    protected static extern IntPtr dlsym(IntPtr handle, string symbol);

    [DllImport("libdl.so")]
    protected static extern IntPtr dlerror();

    IntPtr hLib;

    public H5UnixDllImporter(string libname)
    {
        switch ( libname )
        {
        case "hdf5.dll":
            libname = "/usr/lib/libhdf5.so";
            break;

        case "hdf5_hd.dll":
            libname = "/usr/lib/libhdf5_hl.so";
            break;
        }

        this.hLib = dlopen(libname, RTLD_NOW);
        if ( this.hLib == IntPtr.Zero )
        {
            throw new ArgumentException(
                String.Format(
                    "Unable to load unmanaged module \"{0}\"",
                    libname));
        }
    }

    protected override IntPtr GetAddress(string varName)
    {
        IntPtr address = dlsym(hLib, varName);
        IntPtr errPtr = dlerror();
        if ( errPtr != IntPtr.Zero )
        {
            throw new Exception("dlsym: " + Marshal.PtrToStringAnsi(errPtr));
        }
        return address;
    }
}
