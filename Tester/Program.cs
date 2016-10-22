using HDF5Mock.Methods;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace Tester
{
    internal static class Tests
    {
        public static void testLazyInit( long count )
        {
            count -= 2;
            for (var i = 0; i < count; i++)
            {
                var a = LazyInit.IEEE_F32BE;
            }
            var b = LazyInit.IEEE_F32LE;
            var c = LazyInit.IEEE_F64BE;
        }

        public static void testLazyInitInterlocked1( long count )
        {
            count -= 2;
            for (var i = 0; i < count; i++)
            {
                var a = LazyInitInterlocked1.IEEE_F32BE;
            }
            var b = LazyInitInterlocked1.IEEE_F32LE;
            var c = LazyInitInterlocked1.IEEE_F64BE;
        }

        public static void testLazyInitInterlocked2( long count )
        {
            count -= 2;
            for (var i = 0; i < count; i++)
            {
                var a = LazyInitInterlocked2.IEEE_F32BE;
            }
            var b = LazyInitInterlocked2.IEEE_F32LE;
            var c = LazyInitInterlocked2.IEEE_F64BE;
        }

        public static void testLazyInitInterlocked3( long count )
        {
            count -= 2;
            for (var i = 0; i < count; i++)
            {
                var a = LazyInitInterlocked3.IEEE_F32BE;
            }
            var b = LazyInitInterlocked3.IEEE_F32LE;
            var c = LazyInitInterlocked3.IEEE_F64BE;
        }

        public static void testStaticInitProperty( long count )
        {
            count -= 2;
            for (var i = 0; i < count; i++)
            {
                var a = StaticInitProperty.IEEE_F32BE;
            }
            var b = StaticInitProperty.IEEE_F32LE;
            var c = StaticInitProperty.IEEE_F64BE;
        }
    }

    internal class Program
    {
        private static void Main( string[] args )
        {
            try
            {
                var method = args[0];
                var count = Int64.Parse(args[1]);

                var func = (Action<long>) Delegate.CreateDelegate(typeof(Action<long>), typeof(Tests).GetMethod("test"+method, BindingFlags.Static | BindingFlags.Public));

                var watch = Stopwatch.StartNew();
                func( count );
                watch.Stop();
                Console.Write( watch.Elapsed.TotalSeconds.ToString( CultureInfo.InvariantCulture ) );
            }
            catch (Exception e)
            {
                Console.WriteLine( e.ToString() );
            }
        }
    }
}