using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string type = "";
            double price = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    budget *= 0.3;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    budget *= 0.7;
                    type = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    budget *= 0.4;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    budget *= 0.8;
                    type = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                budget *= 0.9;
                type = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {budget:f2}");
        }
    }
}
