using System;

namespace _05._Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double meters = 5364;
            int days = 1;

            while (input != "END")
            {
                double metersClimbed = double.Parse(Console.ReadLine());

                if (input == "Yes")
                {
                    days++;
                }

                meters += metersClimbed;

                if (days > 5)
                {
                    meters -= metersClimbed;
                    break;
                }


                if (meters >= 8848)
                {
                    
                    break;
                }

                input = Console.ReadLine();
            }

            if (meters < 8848 || days > 5)
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{meters}");
            }
            else if (meters >= 8848)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
        }
    }
}
