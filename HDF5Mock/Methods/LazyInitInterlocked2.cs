using hid_t = System.Int64;

namespace HDF5Mock.Methods
{
    public unsafe static class LazyInitInterlocked2
    {
        private static H5DLLImporter m_importer = H5DLLImporter.Create( "hdf5.dll" );

        private static int bH5T_IEEE_F32BE_g;
        private static hid_t H5T_IEEE_F32BE_g;

        public static hid_t IEEE_F32BE
        {
            get
            {
                if (bH5T_IEEE_F32BE_g != 0)
                    return H5T_IEEE_F32BE_g;

                H5T_IEEE_F32BE_g = m_importer.ReadHid( "H5T_IEEE_F32BE_g" );
                System.Threading.Interlocked.Increment( ref bH5T_IEEE_F32BE_g );
                return H5T_IEEE_F32BE_g;
            }
        }

        private static int bH5T_IEEE_F32LE_g;
        private static hid_t H5T_IEEE_F32LE_g;

        public static hid_t IEEE_F32LE
        {
            get
            {
                if (bH5T_IEEE_F32LE_g != 0)
                    return H5T_IEEE_F32LE_g;

                H5T_IEEE_F32LE_g = m_importer.ReadHid( "H5T_IEEE_F32BE_g" );
                System.Threading.Interlocked.Increment( ref bH5T_IEEE_F32LE_g );
                return H5T_IEEE_F32LE_g;
            }
        }

        private static int bH5T_IEEE_F64BE_g;
        private static hid_t H5T_IEEE_F64BE_g;

        public static hid_t IEEE_F64BE
        {
            get
            {
                if (bH5T_IEEE_F64BE_g != 0)
                    return H5T_IEEE_F64BE_g;

                H5T_IEEE_F64BE_g = m_importer.ReadHid( "H5T_IEEE_F64BE_g" );
                System.Threading.Interlocked.Increment( ref bH5T_IEEE_F64BE_g );
                return H5T_IEEE_F64BE_g;
            }
        }
    }
}