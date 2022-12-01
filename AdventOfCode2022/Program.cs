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
                Day1();
                break;
            default:
                Console.WriteLine("That day has not been implemented yet, pick a different day");
                break;
        }

        static void Day1()
        {
            slowLog("Reading data from website");
            string data = File.ReadAllText(@"C:\Users\max_v\source\repos\AdventOfCode2022\AdventOfCode2022\Data\Day1Data.txt");

            slowLog("Extracting data to array");
            string[] lineData = data.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.None
            );

            slowLog("Calculating sums of elves callories");
            List<int> elves = new List<int>();
            int intake = 0;
            foreach (string line in lineData)
            {
                if (line != "")
                {
                    intake += int.Parse(line);
                }
                else
                {
                    elves.Add(intake);
                    intake = 0;
                }
            }

            slowLog("Finding elve with most callories");
            elves.Sort();
            elves.Reverse();

            slowLog("Elf with most callories has: " + elves.First() + " callories");
            slowLog("Updating task: Find sum of top 3 highest callorie elves");

            int top3Total = 0;
            for(int i = 0; i < 3; i++)
            {
                top3Total += elves[i];
            }

            slowLog("Total of top 3 elves: " + top3Total);
        }

        static void slowLog(string log)
        {
            Console.WriteLine(log);
            Thread.Sleep(2000);
        }
    }
}