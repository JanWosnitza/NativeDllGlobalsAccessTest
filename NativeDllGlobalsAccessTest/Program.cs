using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace NativeDllGlobalsAccessTest
{
    internal class Test
    {
        private const long Count1 = 20000000;
        private const long Count2 = Count1 * 10;

        public string Name;

        private readonly List<double> Times1 = new List<double>();
        private readonly List<double> Times2 = new List<double>();

        public Test( string name )
        {
            this.Name = name;
        }

        public void Test1()
        {
            Times1.Add( Execute( Count1 ) );
        }

        public void Test2()
        {
            Times2.Add( Execute( Count2 ) );
        }

        private double Execute( long count )
        {
            var startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardInput = true;

            startInfo.UseShellExecute = false;
            startInfo.Arguments = $"{this.Name} {count}";
            startInfo.FileName = "Tester.exe";

            using (var process = new Process())
            {
                process.StartInfo = startInfo;

                process.Start();
                process.WaitForExit();
                var text = process.StandardOutput.ReadToEnd();

                try
                {
                    return double.Parse( text, CultureInfo.InvariantCulture );
                }
                catch
                {
                    Console.WriteLine( text );
                    throw;
                }
            }
        }

        private static double GetMedian( IEnumerable<double> seq )
        {
            var arr = seq.OrderBy(x=>x).ToArray();
            return arr[ arr.Length / 2 ];
        }

        public void Print()
        {
            var time1 = GetMedian(this.Times1);
            var time2 = GetMedian(this.Times2);

            var accessTime = (time1 - time2) / (Count1 - Count2);
            var initTime = time2 - accessTime * Count2;

            Console.WriteLine( $"{this.Name}:" );
            Console.WriteLine( $"    total-time  = {time1 + time2}" );
            Console.WriteLine( $"    access-time = {accessTime}" );
            Console.WriteLine( $"    initTime    = {initTime}" );
            Console.WriteLine( $"    -> {initTime}+{accessTime}*x" );
        }
    }

    internal class Program
    {
        private static void Main( string[] args )
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

            var testNames = new []{ /*"LazyInit",*/ "LazyInitInterlocked1", "LazyInitInterlocked2", "LazyInitInterlocked3", "StaticInitProperty" };
            var tests = testNames.Select(x => new Test(x)).ToArray();

            var testRange =
                Enumerable.Range(0, 20)
                    .SelectMany(x => tests)
                    .SelectMany(x => new Action[] { x.Test1, x.Test2 })
                    .Shuffle()
                    .ToArray();

            for (var i = 0; i < testRange.Length; i++)
            {
                Console.Write( $"\rTest {i * 100 / testRange.Length}%" );
                testRange[ i ]();
            }
            Console.WriteLine( "\rTest 100%" );

            foreach (var test in tests)
                test.Print();
        }
    }
}