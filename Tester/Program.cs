using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDF5Mock.Methods;

using hid_t = System.Int64;
using System.Reflection;

namespace Tester
{
    static class Tests
    {
        public static void LazyInit1(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = LazyInit.IEEE_F32BE;
            }
        }

        public static void LazyInit2(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = LazyInit.IEEE_F32BE;
                var b = LazyInit.IEEE_F32LE;
            }
        }

        public static void LazyInit3(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = LazyInit.IEEE_F32BE;
                var b = LazyInit.IEEE_F32LE;
                var c = LazyInit.IEEE_F64BE;
            }
        }

        public static void LazyInitInterlocked1(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = LazyInitInterlocked.IEEE_F32BE;
            }
        }

        public static void StaticInitProperty1(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = StaticInitProperty.IEEE_F32BE;
            }
        }

        public static void LazyInitInterlocked2(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = LazyInitInterlocked.IEEE_F32BE;
                var b = LazyInitInterlocked.IEEE_F32LE;
            }
        }

        public static void LazyInitInterlocked3(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = LazyInitInterlocked.IEEE_F32BE;
                var b = LazyInitInterlocked.IEEE_F32LE;
                var c = LazyInitInterlocked.IEEE_F64BE;
            }
        }

        public static void StaticInitField2(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = StaticInitField.IEEE_F32BE;
                var b = StaticInitField.IEEE_F32LE;
            }
        }

        public static void StaticInitField3(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = StaticInitField.IEEE_F32BE;
                var b = StaticInitField.IEEE_F32LE;
                var c = StaticInitField.IEEE_F64BE;
            }
        }

        public static void StaticInitField1(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = StaticInitField.IEEE_F32BE;
            }
        }

        public static void StaticInitProperty2(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = StaticInitProperty.IEEE_F32BE;
                var b = StaticInitProperty.IEEE_F32LE;
            }
        }

        public static void StaticInitProperty3(long count)
        {
            for ( var i = 0; i < count; i++ )
            {
                var a = StaticInitProperty.IEEE_F32BE;
                var b = StaticInitProperty.IEEE_F32LE;
                var c = StaticInitProperty.IEEE_F64BE;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = args[0];
            var count = Int64.Parse(args[1]);

            var func = (Action<long>) Delegate.CreateDelegate(typeof(Action<long>), typeof(Tests).GetMethod(method, BindingFlags.Static | BindingFlags.Public));

            var watch = Stopwatch.StartNew();
            func(count);
            watch.Stop();
            Console.Write(watch.Elapsed.TotalSeconds.ToString(CultureInfo.InvariantCulture));
        }
    }
}
