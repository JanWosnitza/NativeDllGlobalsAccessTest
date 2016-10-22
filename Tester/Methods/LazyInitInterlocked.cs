using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hid_t = System.Int64;

namespace Tester.Methods
{
    class LazyInitInterlocked
    {
        static H5DLLImporter m_importer = H5DLLImporter.Create("hdf5.dll");

        private const hid_t HID_UNINITIALIZED = -1;

        static hid_t H5T_IEEE_F32BE_g;

        public static hid_t IEEE_F32BE
        {
            get
            {
                if (System.Threading.Interlocked.Read(ref H5T_IEEE_F32BE_g) == HID_UNINITIALIZED)
                {
                    hid_t val = m_importer.ReadHid("H5T_IEEE_F32BE_g");
                    System.Threading.Interlocked.CompareExchange(ref H5T_IEEE_F32BE_g, val, HID_UNINITIALIZED);
                }
                return H5T_IEEE_F32BE_g;
            }
        }
    }
}
