using System.IO;

namespace Aoc_2015_Day3
{
    internal class main
    {
        static void part1(string input)
        {
            HashSet<string> houses = new HashSet<string>();
            int x = 0, y = 0;
            foreach (char c in input)
            {
                if (c == '>')
                    x++;
                if (c == '<')
                    x--;
                if (c == '^')
                    y++;
                if (c == 'v')
                    y--;
                houses.Add(x.ToString() + y.ToString());
            }
            Console.WriteLine("Part 1 answer: " + (houses.Count + 1));
        }

        static void part2(string input)
        {
            HashSet<string> houses = new HashSet<string>();
            int counter = 0, x=0,y=0,x1=0,y1=0;
            foreach (char c in input)
            {
                if (counter%2 == 0)
                {
                    if (c == '>')
                        x++;
                    if (c == '<')
                        x--;
                    if (c == '^')
                        y++;
                    if (c == 'v')
                        y--;
                    houses.Add(x.ToString() + y.ToString());
                }
                else
                {
                    if (c == '>')
                        x1++;
                    if (c == '<')
                        x1--;
                    if (c == '^')
                        y1++;
                    if (c == 'v')
                        y1--;
                    houses.Add(x1.ToString() + y1.ToString());
                }

                counter++;
            }
            Console.WriteLine("Part 2 answer: " + (houses.Count));
        }

        static void Main(string[] args)
        {
            string input = File.ReadAllText("../../../input.txt");
            part1 (input);
            part2 (input);
        }
    }
}
