using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NativeDllGlobalsAccessTest
{
    class Program
    {
        static double Execute(string name, long count)
        {
            var startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardInput = true;

            startInfo.UseShellExecute = false;
            startInfo.Arguments = $"{name} {count}";
            startInfo.FileName = "Tester.exe";

            using ( var process = new Process() )
            {
                process.StartInfo = startInfo;

                /*process.OutputDataReceived += (s, e) =>
                {
                    using ( var output = process.StandardOutput )
                    {
                        text.Append(output.ReadToEnd());
                    }
                };*/
                process.Start();
                var text = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return double.Parse(text, CultureInfo.InvariantCulture);
            }
        }

        const long Count1 = 10000000;
        const long Count2 = Count1 * 10;

        static void Test(string name)
        {
            var time1 = Execute(name, Count1);
            var time2 = Execute(name, Count2);

            var accessTime = (time1 - time2) / (Count1 - Count2);
            var initTime = time2 - accessTime * Count2;

            Console.WriteLine($"{name}: total-time: {time1+time2}, access-time = {accessTime}, initTime = {initTime}");
        }

        static void Main(string[] args)
        {
            // init
            //Execute<LazyInit>(10);

            // test
            Test("LazyInit");
            Test("LazyInitInterlocked");
            Test("StaticInitProperty");
            Test("StaticInitField");
        }
    }
}
