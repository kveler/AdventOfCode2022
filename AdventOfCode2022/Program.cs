using AdventOfCode2022;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, welcome to the Advent of Code 2022 solution program of Kveler\n\n");
        Console.Write("Select a day: ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear();
                Day1Solver day1 = new Day1Solver();
                day1.Day1();
                break;
            default:
                Console.WriteLine("That day has not been implemented yet, pick a different day");
                break;
        }
    }
}