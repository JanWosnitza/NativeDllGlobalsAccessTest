using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hid_t = System.Int64;

namespace Tester.Methods
{
    class LazyInit
    {
        static H5DLLImporter m_importer = H5DLLImporter.Create("hdf5.dll");

        static hid_t? H5T_IEEE_F32BE_g;

        public static hid_t IEEE_F32BE
        {
            get
            {
                if ( !H5T_IEEE_F32BE_g.HasValue )
                {
                    H5T_IEEE_F32BE_g = m_importer.ReadHid("H5T_IEEE_F32BE_g");
                }
                return H5T_IEEE_F32BE_g.GetValueOrDefault();
            }
        }
    }
}
