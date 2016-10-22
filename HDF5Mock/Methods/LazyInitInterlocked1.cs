using hid_t = System.Int64;

namespace HDF5Mock.Methods
{
    public unsafe static class LazyInitInterlocked1
    {
        private static H5DLLImporter m_importer = H5DLLImporter.Create( "hdf5.dll" );

        private static hid_t H5T_IEEE_F32BE_g;

        public static hid_t IEEE_F32BE
        {
            get
            {
                if (System.Threading.Interlocked.Read( ref H5T_IEEE_F32BE_g ) == default( hid_t ))
                {
                    hid_t val = m_importer.ReadHid("H5T_IEEE_F32BE_g");
                    System.Threading.Interlocked.CompareExchange( ref H5T_IEEE_F32BE_g, val, default( hid_t ) );
                }
                return H5T_IEEE_F32BE_g;
            }
        }

        private static hid_t H5T_IEEE_F32LE_g;

        public static hid_t IEEE_F32LE
        {
            get
            {
                if (System.Threading.Interlocked.Read( ref H5T_IEEE_F32LE_g ) == default( hid_t ))
                {
                    hid_t val = m_importer.ReadHid("H5T_IEEE_F32LE_g");
                    System.Threading.Interlocked.CompareExchange( ref H5T_IEEE_F32LE_g, val, default( hid_t ) );
                }
                return H5T_IEEE_F32LE_g;
            }
        }

        private static hid_t H5T_IEEE_F64BE_g;

        public static hid_t IEEE_F64BE
        {
            get
            {
                if (System.Threading.Interlocked.Read( ref H5T_IEEE_F64BE_g ) == default( hid_t ))
                {
                    hid_t val = m_importer.ReadHid("H5T_IEEE_F64BE_g");
                    System.Threading.Interlocked.CompareExchange( ref H5T_IEEE_F64BE_g, val, default( hid_t ) );
                }
                return H5T_IEEE_F64BE_g;
            }
        }
    }
}