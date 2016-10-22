using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tester.Methods;

using hid_t = System.Int64;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var method = args[0];
            var count = Int64.Parse(args[1]);

            Func<hid_t> func;
            switch ( method )
            {
            case "LazyInit":
                func = () => LazyInit.IEEE_F32BE;
                break;
            case "LazyInitInterlocked":
                func = () => LazyInitInterlocked.IEEE_F32BE;
                break;
            case "StaticInitField":
                func = () => StaticInitField.IEEE_F32BE;
                break;
            case "StaticInitProperty":
                func = () => StaticInitProperty.IEEE_F32BE;
                break;
            default:
                throw new NotImplementedException();
            }

            var watch = Stopwatch.StartNew();
            for ( var i = 0; i < count; i++ )
            {
                func();
            }
            watch.Stop();
            Console.Write(watch.Elapsed.TotalSeconds.ToString(CultureInfo.InvariantCulture));
        }
    }
}
