using System;

using hid_t = System.Int64;

namespace HDF5Mock.Methods
{
    public unsafe static class LazyInitInterlocked3
    {
        private static H5DLLImporter m_importer = H5DLLImporter.Create( "hdf5.dll" );

        private static IntPtr H5T_IEEE_F32BE_g;

        public static hid_t IEEE_F32BE
        {
            get
            {
                if (H5T_IEEE_F32BE_g != default( IntPtr ))
                    return *(hid_t*) H5T_IEEE_F32BE_g;

                var addr = m_importer.GetAddress("H5T_IEEE_F32BE_g");
                System.Threading.Interlocked.Exchange( ref H5T_IEEE_F32BE_g, addr );
                return *(hid_t*) H5T_IEEE_F32BE_g;
            }
        }

        private static IntPtr H5T_IEEE_F32LE_g;

        public static hid_t IEEE_F32LE
        {
            get
            {
                if (H5T_IEEE_F32LE_g != default( IntPtr ))
                    return *(hid_t*) H5T_IEEE_F32LE_g;

                var addr = m_importer.GetAddress("H5T_IEEE_F32BE_g");
                System.Threading.Interlocked.Exchange( ref H5T_IEEE_F32LE_g, addr );
                return *(hid_t*) H5T_IEEE_F32LE_g;
            }
        }

        private static IntPtr H5T_IEEE_F64BE_g;

        public static hid_t IEEE_F64BE
        {
            get
            {
                if (H5T_IEEE_F64BE_g != default( IntPtr ))
                    return *(hid_t*) H5T_IEEE_F64BE_g;

                var addr = m_importer.GetAddress("H5T_IEEE_F64BE_g");
                System.Threading.Interlocked.Exchange( ref H5T_IEEE_F64BE_g, addr );
                return *(hid_t*) H5T_IEEE_F64BE_g;
            }
        }
    }
}