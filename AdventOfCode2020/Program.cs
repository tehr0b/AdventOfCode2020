using System;
using System.Diagnostics;

namespace AdventOfCode2020 {
    internal class Program {
        public static void Main(string[] args) {
            
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            
            //var day1 = new Day1();
            //var day2 = new Day2();
            //var day3 = new Day3();
            var day4 = new Day4();
            
            //day1.Run();
            //day2.Run();
            //day3.Run();
            day4.Run();
            
            stopwatch.Stop();
            
            Console.WriteLine($"Finished running in {stopwatch.ElapsedMilliseconds} ms");
        }
    }
    
    public interface Day {
        void Run();
    }
}