using hid_t = System.Int64;

namespace HDF5Mock.Methods
{
    public static class LazyInit
    {
        private static H5DLLImporter m_importer = H5DLLImporter.Create( "hdf5.dll" );

        private static hid_t? H5T_IEEE_F32BE_g;

        public static hid_t IEEE_F32BE
        {
            get
            {
                if (!H5T_IEEE_F32BE_g.HasValue)
                {
                    H5T_IEEE_F32BE_g = m_importer.ReadHid( "H5T_IEEE_F32BE_g" );
                }
                return H5T_IEEE_F32BE_g.GetValueOrDefault();
            }
        }

        private static hid_t? H5T_IEEE_F32LE_g;

        public static hid_t IEEE_F32LE
        {
            get
            {
                if (!H5T_IEEE_F32LE_g.HasValue)
                {
                    H5T_IEEE_F32LE_g = m_importer.ReadHid( "H5T_IEEE_F32LE_g" );
                }
                return H5T_IEEE_F32LE_g.GetValueOrDefault();
            }
        }

        private static hid_t? H5T_IEEE_F64BE_g;

        public static hid_t IEEE_F64BE
        {
            get
            {
                if (!H5T_IEEE_F64BE_g.HasValue)
                {
                    H5T_IEEE_F64BE_g = m_importer.ReadHid( "H5T_IEEE_F64BE_g" );
                }
                return H5T_IEEE_F64BE_g.GetValueOrDefault();
            }
        }
    }
}