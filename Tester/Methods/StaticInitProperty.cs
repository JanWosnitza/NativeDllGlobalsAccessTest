using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hid_t = System.Int64;

namespace Tester.Methods
{
    class StaticInitProperty
    {
        static H5DLLImporter m_importer = H5DLLImporter.Create("hdf5.dll");
        private const hid_t HID_UNINITIALIZED = -1;

        private static readonly hid_t H5T_IEEE_F32BE_g = m_importer.ReadHid("H5T_IEEE_F32BE_g");
        public static hid_t IEEE_F32BE { get; } = H5T_IEEE_F32BE_g;

        private static readonly hid_t H5T_IEEE_F32LE_g = m_importer.ReadHid("H5T_IEEE_F32LE_g");
        public static hid_t IEEE_F32LE { get; } = H5T_IEEE_F32LE_g;

        private static readonly hid_t H5T_IEEE_F64BE_g = m_importer.ReadHid("H5T_IEEE_F64BE_g");
        public static hid_t IEEE_F64BE { get; } = H5T_IEEE_F64BE_g;

        private static readonly hid_t H5T_IEEE_F64LE_g = m_importer.ReadHid("H5T_IEEE_F64LE_g");
        public static hid_t IEEE_F64LE { get; } = H5T_IEEE_F64LE_g;

        private static readonly hid_t H5T_STD_I8BE_g = m_importer.ReadHid("H5T_STD_I8BE_g");
        public static hid_t STD_I8BE { get; } = H5T_STD_I8BE_g;

        private static readonly hid_t H5T_STD_I8LE_g = m_importer.ReadHid("H5T_STD_I8LE_g");
        public static hid_t STD_I8LE { get; } = H5T_STD_I8LE_g;

        private static readonly hid_t H5T_STD_I16BE_g = m_importer.ReadHid("H5T_STD_I16BE_g");
        public static hid_t STD_I16BE { get; } = H5T_STD_I16BE_g;

        private static readonly hid_t H5T_STD_I16LE_g = m_importer.ReadHid("H5T_STD_I16LE_g");
        public static hid_t STD_I16LE { get; } = H5T_STD_I16LE_g;

        private static readonly hid_t H5T_STD_I32BE_g = m_importer.ReadHid("H5T_STD_I32BE_g");
        public static hid_t STD_I32BE { get; } = H5T_STD_I32BE_g;

        private static readonly hid_t H5T_STD_I32LE_g = m_importer.ReadHid("H5T_STD_I32LE_g");
        public static hid_t STD_I32LE { get; } = H5T_STD_I32LE_g;

        private static readonly hid_t H5T_STD_I64BE_g = m_importer.ReadHid("H5T_STD_I64BE_g");
        public static hid_t STD_I64BE { get; } = H5T_STD_I64BE_g;

        private static readonly hid_t H5T_STD_I64LE_g = m_importer.ReadHid("H5T_STD_I64LE_g");
        public static hid_t STD_I64LE { get; } = H5T_STD_I64LE_g;

        private static readonly hid_t H5T_STD_U8BE_g = m_importer.ReadHid("H5T_STD_U8BE_g");
        public static hid_t STD_U8BE { get; } = H5T_STD_U8BE_g;

        private static readonly hid_t H5T_STD_U8LE_g = m_importer.ReadHid("H5T_STD_U8LE_g");
        public static hid_t STD_U8LE { get; } = H5T_STD_U8LE_g;

        private static readonly hid_t H5T_STD_U16BE_g = m_importer.ReadHid("H5T_STD_U16BE_g");
        public static hid_t STD_U16BE { get; } = H5T_STD_U16BE_g;

        private static readonly hid_t H5T_STD_U16LE_g = m_importer.ReadHid("H5T_STD_U16LE_g");
        public static hid_t STD_U16LE { get; } = H5T_STD_U16LE_g;

        private static readonly hid_t H5T_STD_U32BE_g = m_importer.ReadHid("H5T_STD_U32BE_g");
        public static hid_t STD_U32BE { get; } = H5T_STD_U32BE_g;

        private static readonly hid_t H5T_STD_U32LE_g = m_importer.ReadHid("H5T_STD_U32LE_g");
        public static hid_t STD_U32LE { get; } = H5T_STD_U32LE_g;

        private static readonly hid_t H5T_STD_U64BE_g = m_importer.ReadHid("H5T_STD_U64BE_g");
        public static hid_t STD_U64BE { get; } = H5T_STD_U64BE_g;

        private static readonly hid_t H5T_STD_U64LE_g = m_importer.ReadHid("H5T_STD_U64LE_g");
        public static hid_t STD_U64LE { get; } = H5T_STD_U64LE_g;

        private static readonly hid_t H5T_STD_B8BE_g = m_importer.ReadHid("H5T_STD_B8BE_g");
        public static hid_t STD_B8BE { get; } = H5T_STD_B8BE_g;

        private static readonly hid_t H5T_STD_B8LE_g = m_importer.ReadHid("H5T_STD_B8LE_g");
        public static hid_t STD_B8LE { get; } = H5T_STD_B8LE_g;

        private static readonly hid_t H5T_STD_B16BE_g = m_importer.ReadHid("H5T_STD_B16BE_g");
        public static hid_t STD_B16BE { get; } = H5T_STD_B16BE_g;

        private static readonly hid_t H5T_STD_B16LE_g = m_importer.ReadHid("H5T_STD_B16LE_g");
        public static hid_t STD_B16LE { get; } = H5T_STD_B16LE_g;

        private static readonly hid_t H5T_STD_B32BE_g = m_importer.ReadHid("H5T_STD_B32BE_g");
        public static hid_t STD_B32BE { get; } = H5T_STD_B32BE_g;

        private static readonly hid_t H5T_STD_B32LE_g = m_importer.ReadHid("H5T_STD_B32LE_g");
        public static hid_t STD_B32LE { get; } = H5T_STD_B32LE_g;

        private static readonly hid_t H5T_STD_B64BE_g = m_importer.ReadHid("H5T_STD_B64BE_g");
        public static hid_t STD_B64BE { get; } = H5T_STD_B64BE_g;

        private static readonly hid_t H5T_STD_B64LE_g = m_importer.ReadHid("H5T_STD_B64LE_g");
        public static hid_t STD_B64LE { get; } = H5T_STD_B64LE_g;

        private static readonly hid_t H5T_STD_REF_OBJ_g = m_importer.ReadHid("H5T_STD_REF_OBJ_g");
        public static hid_t STD_REF_OBJ { get; } = H5T_STD_REF_OBJ_g;

        private static readonly hid_t H5T_STD_REF_DSETREG_g = m_importer.ReadHid("H5T_STD_REF_DSETREG_g");
        public static hid_t STD_REF_DSETREG { get; } = H5T_STD_REF_DSETREG_g;

        private static readonly hid_t H5T_UNIX_D32BE_g = m_importer.ReadHid("H5T_UNIX_D32BE_g");
        public static hid_t UNIX_D32BE { get; } = H5T_UNIX_D32BE_g;

        private static readonly hid_t H5T_UNIX_D32LE_g = m_importer.ReadHid("H5T_UNIX_D32LE_g");
        public static hid_t UNIX_D32LE { get; } = H5T_UNIX_D32LE_g;

        private static readonly hid_t H5T_UNIX_D64BE_g = m_importer.ReadHid("H5T_UNIX_D64BE_g");
        public static hid_t UNIX_D64BE { get; } = H5T_UNIX_D64BE_g;

        private static readonly hid_t H5T_UNIX_D64LE_g = m_importer.ReadHid("H5T_UNIX_D64LE_g");
        public static hid_t UNIX_D64LE { get; } = H5T_UNIX_D64LE_g;

        private static readonly hid_t H5T_C_S1_g = m_importer.ReadHid("H5T_C_S1_g");
        public static hid_t C_S1 { get; } = H5T_C_S1_g;

        private static readonly hid_t H5T_FORTRAN_S1_g = m_importer.ReadHid("H5T_FORTRAN_S1_g");
        public static hid_t FORTRAN_S1 { get; } = H5T_FORTRAN_S1_g;

        private static readonly hid_t H5T_VAX_F32_g = m_importer.ReadHid("H5T_VAX_F32_g");
        public static hid_t VAX_F32 { get; } = H5T_VAX_F32_g;

        private static readonly hid_t H5T_VAX_F64_g = m_importer.ReadHid("H5T_VAX_F64_g");
        public static hid_t VAX_F64 { get; } = H5T_VAX_F64_g;

        private static readonly hid_t H5T_NATIVE_SCHAR_g = m_importer.ReadHid("H5T_NATIVE_SCHAR_g");
        public static hid_t NATIVE_SCHAR { get; } = H5T_NATIVE_SCHAR_g;

        private static readonly hid_t H5T_NATIVE_UCHAR_g = m_importer.ReadHid("H5T_NATIVE_UCHAR_g");
        public static hid_t NATIVE_UCHAR { get; } = H5T_NATIVE_UCHAR_g;

        private static readonly hid_t H5T_NATIVE_SHORT_g = m_importer.ReadHid("H5T_NATIVE_SHORT_g");
        public static hid_t NATIVE_SHORT { get; } = H5T_NATIVE_SHORT_g;

        private static readonly hid_t H5T_NATIVE_USHORT_g = m_importer.ReadHid("H5T_NATIVE_USHORT_g");
        public static hid_t NATIVE_USHORT { get; } = H5T_NATIVE_USHORT_g;

        private static readonly hid_t H5T_NATIVE_INT_g = m_importer.ReadHid("H5T_NATIVE_INT_g");
        public static hid_t NATIVE_INT { get; } = H5T_NATIVE_INT_g;

        private static readonly hid_t H5T_NATIVE_UINT_g = m_importer.ReadHid("H5T_NATIVE_UINT_g");
        public static hid_t NATIVE_UINT { get; } = H5T_NATIVE_UINT_g;

        private static readonly hid_t H5T_NATIVE_LONG_g = m_importer.ReadHid("H5T_NATIVE_LONG_g");
        public static hid_t NATIVE_LONG { get; } = H5T_NATIVE_LONG_g;

        private static readonly hid_t H5T_NATIVE_ULONG_g = m_importer.ReadHid("H5T_NATIVE_ULONG_g");
        public static hid_t NATIVE_ULONG { get; } = H5T_NATIVE_ULONG_g;

        private static readonly hid_t H5T_NATIVE_LLONG_g = m_importer.ReadHid("H5T_NATIVE_LLONG_g");
        public static hid_t NATIVE_LLONG { get; } = H5T_NATIVE_LLONG_g;

        private static readonly hid_t H5T_NATIVE_ULLONG_g = m_importer.ReadHid("H5T_NATIVE_ULLONG_g");
        public static hid_t NATIVE_ULLONG { get; } = H5T_NATIVE_ULLONG_g;

        private static readonly hid_t H5T_NATIVE_FLOAT_g = m_importer.ReadHid("H5T_NATIVE_FLOAT_g");
        public static hid_t NATIVE_FLOAT { get; } = H5T_NATIVE_FLOAT_g;

        private static readonly hid_t H5T_NATIVE_DOUBLE_g = m_importer.ReadHid("H5T_NATIVE_DOUBLE_g");
        public static hid_t NATIVE_DOUBLE { get; } = H5T_NATIVE_DOUBLE_g;

        private static readonly hid_t H5T_NATIVE_LDOUBLE_g = m_importer.ReadHid("H5T_NATIVE_LDOUBLE_g");
        public static hid_t NATIVE_LDOUBLE { get; } = H5T_NATIVE_LDOUBLE_g;

        private static readonly hid_t H5T_NATIVE_B8_g = m_importer.ReadHid("H5T_NATIVE_B8_g");
        public static hid_t NATIVE_B8 { get; } = H5T_NATIVE_B8_g;

        private static readonly hid_t H5T_NATIVE_B16_g = m_importer.ReadHid("H5T_NATIVE_B16_g");
        public static hid_t NATIVE_B16 { get; } = H5T_NATIVE_B16_g;

        private static readonly hid_t H5T_NATIVE_B32_g = m_importer.ReadHid("H5T_NATIVE_B32_g");
        public static hid_t NATIVE_B32 { get; } = H5T_NATIVE_B32_g;

        private static readonly hid_t H5T_NATIVE_B64_g = m_importer.ReadHid("H5T_NATIVE_B64_g");
        public static hid_t NATIVE_B64 { get; } = H5T_NATIVE_B64_g;

        private static readonly hid_t H5T_NATIVE_OPAQUE_g = m_importer.ReadHid("H5T_NATIVE_OPAQUE_g");
        public static hid_t NATIVE_OPAQUE { get; } = H5T_NATIVE_OPAQUE_g;

        private static readonly hid_t H5T_NATIVE_HADDR_g = m_importer.ReadHid("H5T_NATIVE_HADDR_g");
        public static hid_t NATIVE_HADDR { get; } = H5T_NATIVE_HADDR_g;

        private static readonly hid_t H5T_NATIVE_HSIZE_g = m_importer.ReadHid("H5T_NATIVE_HSIZE_g");
        public static hid_t NATIVE_HSIZE { get; } = H5T_NATIVE_HSIZE_g;

        private static readonly hid_t H5T_NATIVE_HSSIZE_g = m_importer.ReadHid("H5T_NATIVE_HSSIZE_g");
        public static hid_t NATIVE_HSSIZE { get; } = H5T_NATIVE_HSSIZE_g;

        private static readonly hid_t H5T_NATIVE_HERR_g = m_importer.ReadHid("H5T_NATIVE_HERR_g");
        public static hid_t NATIVE_HERR { get; } = H5T_NATIVE_HERR_g;

        private static readonly hid_t H5T_NATIVE_HBOOL_g = m_importer.ReadHid("H5T_NATIVE_HBOOL_g");
        public static hid_t NATIVE_HBOOL { get; } = H5T_NATIVE_HBOOL_g;

        private static readonly hid_t H5T_NATIVE_INT8_g = m_importer.ReadHid("H5T_NATIVE_INT8_g");
        public static hid_t NATIVE_INT8 { get; } = H5T_NATIVE_INT8_g;

        private static readonly hid_t H5T_NATIVE_UINT8_g = m_importer.ReadHid("H5T_NATIVE_UINT8_g");
        public static hid_t NATIVE_UINT8 { get; } = H5T_NATIVE_UINT8_g;

        private static readonly hid_t H5T_NATIVE_INT_LEAST8_g = m_importer.ReadHid("H5T_NATIVE_INT_LEAST8_g");
        public static hid_t NATIVE_INT_LEAST8 { get; } = H5T_NATIVE_INT_LEAST8_g;

        private static readonly hid_t H5T_NATIVE_UINT_LEAST8_g = m_importer.ReadHid("H5T_NATIVE_UINT_LEAST8_g");
        public static hid_t NATIVE_UINT_LEAST8 { get; } = H5T_NATIVE_UINT_LEAST8_g;

        private static readonly hid_t H5T_NATIVE_INT_FAST8_g = m_importer.ReadHid("H5T_NATIVE_INT_FAST8_g");
        public static hid_t NATIVE_INT_FAST8 { get; } = H5T_NATIVE_INT_FAST8_g;

        private static readonly hid_t H5T_NATIVE_UINT_FAST8_g = m_importer.ReadHid("H5T_NATIVE_UINT_FAST8_g");
        public static hid_t NATIVE_UINT_FAST8 { get; } = H5T_NATIVE_UINT_FAST8_g;

        private static readonly hid_t H5T_NATIVE_INT16_g = m_importer.ReadHid("H5T_NATIVE_INT16_g");
        public static hid_t NATIVE_INT16 { get; } = H5T_NATIVE_INT16_g;

        private static readonly hid_t H5T_NATIVE_UINT16_g = m_importer.ReadHid("H5T_NATIVE_UINT16_g");
        public static hid_t NATIVE_UINT16 { get; } = H5T_NATIVE_UINT16_g;

        private static readonly hid_t H5T_NATIVE_INT_LEAST16_g = m_importer.ReadHid("H5T_NATIVE_INT_LEAST16_g");
        public static hid_t NATIVE_INT_LEAST16 { get; } = H5T_NATIVE_INT_LEAST16_g;

        private static readonly hid_t H5T_NATIVE_UINT_LEAST16_g = m_importer.ReadHid("H5T_NATIVE_UINT_LEAST16_g");
        public static hid_t NATIVE_UINT_LEAST16 { get; } = H5T_NATIVE_UINT_LEAST16_g;

        private static readonly hid_t H5T_NATIVE_INT_FAST16_g = m_importer.ReadHid("H5T_NATIVE_INT_FAST16_g");
        public static hid_t NATIVE_INT_FAST16 { get; } = H5T_NATIVE_INT_FAST16_g;

        private static readonly hid_t H5T_NATIVE_UINT_FAST16_g = m_importer.ReadHid("H5T_NATIVE_UINT_FAST16_g");
        public static hid_t NATIVE_UINT_FAST16 { get; } = H5T_NATIVE_UINT_FAST16_g;

        private static readonly hid_t H5T_NATIVE_INT32_g = m_importer.ReadHid("H5T_NATIVE_INT32_g");
        public static hid_t NATIVE_INT32 { get; } = H5T_NATIVE_INT32_g;

        private static readonly hid_t H5T_NATIVE_UINT32_g = m_importer.ReadHid("H5T_NATIVE_UINT32_g");
        public static hid_t NATIVE_UINT32 { get; } = H5T_NATIVE_UINT32_g;

        private static readonly hid_t H5T_NATIVE_INT_LEAST32_g = m_importer.ReadHid("H5T_NATIVE_INT_LEAST32_g");
        public static hid_t NATIVE_INT_LEAST32 { get; } = H5T_NATIVE_INT_LEAST32_g;

        private static readonly hid_t H5T_NATIVE_UINT_LEAST32_g = m_importer.ReadHid("H5T_NATIVE_UINT_LEAST32_g");
        public static hid_t NATIVE_UINT_LEAST32 { get; } = H5T_NATIVE_UINT_LEAST32_g;

        private static readonly hid_t H5T_NATIVE_INT_FAST32_g = m_importer.ReadHid("H5T_NATIVE_INT_FAST32_g");
        public static hid_t NATIVE_INT_FAST32 { get; } = H5T_NATIVE_INT_FAST32_g;

        private static readonly hid_t H5T_NATIVE_UINT_FAST32_g = m_importer.ReadHid("H5T_NATIVE_UINT_FAST32_g");
        public static hid_t NATIVE_UINT_FAST32 { get; } = H5T_NATIVE_UINT_FAST32_g;

        private static readonly hid_t H5T_NATIVE_INT64_g = m_importer.ReadHid("H5T_NATIVE_INT64_g");
        public static hid_t NATIVE_INT64 { get; } = H5T_NATIVE_INT64_g;

        private static readonly hid_t H5T_NATIVE_UINT64_g = m_importer.ReadHid("H5T_NATIVE_UINT64_g");
        public static hid_t NATIVE_UINT64 { get; } = H5T_NATIVE_UINT64_g;

        private static readonly hid_t H5T_NATIVE_INT_LEAST64_g = m_importer.ReadHid("H5T_NATIVE_INT_LEAST64_g");
        public static hid_t NATIVE_INT_LEAST64 { get; } = H5T_NATIVE_INT_LEAST64_g;

        private static readonly hid_t H5T_NATIVE_UINT_LEAST64_g = m_importer.ReadHid("H5T_NATIVE_UINT_LEAST64_g");
        public static hid_t NATIVE_UINT_LEAST64 { get; } = H5T_NATIVE_UINT_LEAST64_g;

        private static readonly hid_t H5T_NATIVE_INT_FAST64_g = m_importer.ReadHid("H5T_NATIVE_INT_FAST64_g");
        public static hid_t NATIVE_INT_FAST64 { get; } = H5T_NATIVE_INT_FAST64_g;

        private static readonly hid_t H5T_NATIVE_UINT_FAST64_g = m_importer.ReadHid("H5T_NATIVE_UINT_FAST64_g");
        public static hid_t NATIVE_UINT_FAST64 { get; } = H5T_NATIVE_UINT_FAST64_g;

        public static hid_t INTEL_I8 { get; } = H5T_STD_I8LE_g;

        public static hid_t INTEL_I16 { get; } = H5T_STD_I16LE_g;

        public static hid_t INTEL_I32 { get; } = H5T_STD_I32LE_g;

        public static hid_t INTEL_I64 { get; } = H5T_STD_I64LE_g;

        public static hid_t INTEL_U8 { get; } = H5T_STD_U8LE_g;

        public static hid_t INTEL_U16 { get; } = H5T_STD_U16LE_g;

        public static hid_t INTEL_U32 { get; } = H5T_STD_U32LE_g;

        public static hid_t INTEL_U64 { get; } = H5T_STD_U64LE_g;

        public static hid_t INTEL_B8 { get; } = H5T_STD_B8LE_g;

        public static hid_t INTEL_B16 { get; } = H5T_STD_B16LE_g;

        public static hid_t INTEL_B32 { get; } = H5T_STD_B32LE_g;

        public static hid_t INTEL_B64 { get; } = H5T_STD_B64LE_g;

        public static hid_t INTEL_F32 { get; } = H5T_IEEE_F32LE_g;

        public static hid_t INTEL_F64 { get; } = H5T_IEEE_F64LE_g;

        public static hid_t ALPHA_I8 { get; } = H5T_STD_I8LE_g;

        public static hid_t ALPHA_I16 { get; } = H5T_STD_I16LE_g;

        public static hid_t ALPHA_I32 { get; } = H5T_STD_I32LE_g;

        public static hid_t ALPHA_I64 { get; } = H5T_STD_I64LE_g;

        public static hid_t ALPHA_U8 { get; } = H5T_STD_U8LE_g;

        public static hid_t ALPHA_U16 { get; } = H5T_STD_U16LE_g;

        public static hid_t ALPHA_U32 { get; } = H5T_STD_U32LE_g;

        public static hid_t ALPHA_U64 { get; } = H5T_STD_U64LE_g;

        public static hid_t ALPHA_B8 { get; } = H5T_STD_B8LE_g;

        public static hid_t ALPHA_B16 { get; } = H5T_STD_B16LE_g;

        public static hid_t ALPHA_B32 { get; } = H5T_STD_B32LE_g;

        public static hid_t ALPHA_B64 { get; } = H5T_STD_B64LE_g;

        public static hid_t ALPHA_F32 { get; } = H5T_IEEE_F32LE_g;

        public static hid_t ALPHA_F64 { get; } = H5T_IEEE_F64LE_g;

        public static hid_t MIPS_I8 { get; } = H5T_STD_I8BE_g;

        public static hid_t MIPS_I16 { get; } = H5T_STD_I16BE_g;

        public static hid_t MIPS_I32 { get; } = H5T_STD_I32BE_g;

        public static hid_t MIPS_I64 { get; } = H5T_STD_I64BE_g;

        public static hid_t MIPS_U8 { get; } = H5T_STD_U8BE_g;

        public static hid_t MIPS_U16 { get; } = H5T_STD_U16BE_g;

        public static hid_t MIPS_U32 { get; } = H5T_STD_U32BE_g;

        public static hid_t MIPS_U64 { get; } = H5T_STD_U64BE_g;

        public static hid_t MIPS_B8 { get; } = H5T_STD_B8BE_g;

        public static hid_t MIPS_B16 { get; } = H5T_STD_B16BE_g;

        public static hid_t MIPS_B32 { get; } = H5T_STD_B32BE_g;

        public static hid_t MIPS_B64 { get; } = H5T_STD_B64BE_g;

        public static hid_t MIPS_F32 { get; } = H5T_IEEE_F32BE_g;

        public static hid_t MIPS_F64 { get; } = H5T_IEEE_F64BE_g;

        public static hid_t NATIVE_CHAR { get; } = H5T_NATIVE_SCHAR_g;
    }
}