using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int totalSteps = 0;

            while (totalSteps < 10000)
            {
                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    int steps = int.Parse(input);
                    totalSteps += steps;
                    if (totalSteps < 10000)
                    {
                        Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
                        break;
                    }
                }
                else
                {
                    int steps = int.Parse(input);
                    totalSteps += steps;
                    if (totalSteps >= 10000)
                    {
                        break;
                    }
                }

                input = Console.ReadLine();
            }
            if (totalSteps >= 10000)
            {
                int stepsOver = Math.Abs(10000 - totalSteps);
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsOver} steps over the goal!");
            }
        }
    }
}
