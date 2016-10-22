﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NativeDllGlobalsAccessTest
{
    class Test
    {
        const long Count1 = 10000000;
        const long Count2 = Count1 * 10;

        public string Name;

        private readonly List<double> Times1 = new List<double>();
        private readonly List<double> Times2 = new List<double>();

        public Test(string name)
        {
            this.Name = name;
        }

        public void TestOnce()
        {
            var time1 = Execute(Count1);
            var time2 = Execute(Count2);

            Times1.Add(time1);
            Times2.Add(time2);
        }

        double Execute(long count)
        {
            var startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardInput = true;

            startInfo.UseShellExecute = false;
            startInfo.Arguments = $"{this.Name} {count}";
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

        static double GetMedian(IEnumerable<double> seq)
        {
            var arr = seq.OrderBy(x=>x).ToArray();
            return arr[arr.Length / 2];
        }

        public void Print()
        {
            var time1 = GetMedian(this.Times1);
            var time2 = GetMedian(this.Times2);

            var accessTime = (time1 - time2) / (Count1 - Count2);
            var initTime = time2 - accessTime * Count2;

            Console.WriteLine($"{this.Name}:");
            Console.WriteLine($"    total-time  = {time1 + time2}");
            Console.WriteLine($"    access-time = {accessTime}");
            Console.WriteLine($"    initTime    = {initTime}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // init
            //Execute<LazyInit>(10);

            var testNames = new []{ "LazyInit", "LazyInitInterlocked", "StaticInitProperty", "StaticInitField" };
            var tests = testNames.Select(x => new Test(x)).ToArray();

            var testRange =
                Enumerable.Range(0, 10)
                    .SelectMany(x => tests)
                    .Shuffle()
                    .ToArray();

            for ( var i = 0; i < testRange.Length; i++ )
            {
                Console.Write($"\rTest {i + 1}/{testRange.Length}");
                testRange[i].TestOnce();
            }
            Console.WriteLine();

            foreach ( var test in tests )
                test.Print();
        }
    }
}
