using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    internal class Day2Solver
    {
        internal void Day2()
        {
            string data = File.ReadAllText(@"Data\Day2Data.txt");
            string[] lineData = data.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.None
            );

            int score = 0;
            foreach (string line in lineData)
            {
                string choiceUs = line.Substring(0, 1);
                string choiceThem = line.Substring(line.Length - 1);
                int points = matchResult1(choiceUs, choiceThem);
                score += points;
            }
            Console.WriteLine("Answer part 1: " + score);

            score = 0;
            foreach (string line in lineData)
            {
                string choiceUs = line.Substring(0, 1);
                string choiceThem = line.Substring(line.Length - 1);
                int points = matchResult2(choiceUs, choiceThem);
                score += points;
            }

            Console.WriteLine("Answer part 2: " + score);
        }

        //Rock      A X
        //Paper     B Y
        //Scissors  C Z
        int matchResult1 (string player1, string player2)
        {
            switch (player2)
            {
                case "X":
                    switch (player1)
                    {
                        case "A": //R + R = Draw = 3 + 1
                            return 4;
                        case "B": //R + P = Lose = 0 + 1
                            return 1;
                        case "C": //R + S = Win = 6 + 1
                            return 7;
                    }
                    break;
                case "Y":
                    switch (player1)
                    {
                        case "A": //P + R = Win = 6 + 2
                            return 8;
                        case "B": //P + P = Draw = 3 + 2
                            return 5;
                        case "C": //P + S = Lose = 0 + 2
                            return 2;
                    }
                    break;
                case "Z":
                    switch (player1)
                    {
                        case "A": //S + R = Lose = 0 + 3
                            return 3;
                        case "B": //S + P = Win = 6 + 3
                            return 9;
                        case "C": //S + S = Draw = 3 + 3
                            return 6;
                    }
                    break;
                default:
                    throw new Exception("Mistakes are made");
            }
            throw new Exception("Mistakes are made");
        }

        //Rock      A 1   Lose X
        //Paper     B 2   Draw Y
        //Scissors  C 3   Win Z
        int matchResult2(string player1, string outcome)
        {
            //int score = 0;
            switch (player1)
            {
                case "A":                    
                    switch (outcome)
                    {
                        case "X":
                            return 0 + 3;
                        case "Y":
                            return 3 + 1;
                        case "Z":
                            return 6 + 2;
                    }
                    break;
                case "B":
                    //score += 2;
                    switch (outcome)
                    {
                        case "X":
                            return 0 + 1;
                        case "Y":
                            return 3 + 2;
                        case "Z":
                            return 6 + 3;
                    }
                    break;
                case "C":
                    //score += 3;
                    switch (outcome)
                    {
                        case "X":
                            return 0 + 2;
                        case "Y":
                            return 3 + 3;
                        case "Z":
                            return 6 + 1;
                    }
                    break;
                default:
                    throw new Exception("Mistakes are made");
            }
            throw new Exception("Mistakes are made");
        }
    }
}
