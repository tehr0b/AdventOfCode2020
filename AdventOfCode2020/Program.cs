namespace AdventOfCode2020 {
    internal class Program {
        public static void Main(string[] args) {
            var day1 = new Day1();
            var day2 = new Day2();
            
            //day1.Run();
            day2.Run();
        }
    }
    
    public interface Day {
        void Run();
    }
}