using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int seamen = int.Parse(Console.ReadLine());
            double discount = 0;
            double totalPrice = 0;

            int shipPriceAtSpring = 3000;
            int shipPriceAtAutumnAndSummer = 4200;
            int shipPriceAtWinter = 2600;

            switch (season)
            {
                case "Spring":
                    totalPrice = shipPriceAtSpring;
                    break;
                case "Summer":
                    totalPrice = shipPriceAtAutumnAndSummer;
                    break;
                case "Autumn":
                    totalPrice = shipPriceAtAutumnAndSummer;
                    break;
                case "Winter":
                    totalPrice = shipPriceAtWinter;
                    break;
            }

            if (seamen <= 6)
            {
                discount = 0.1;
            }
            else if (seamen >= 7 && seamen <= 11)
            {
                discount = 0.15;
            }
            else if (seamen >= 12)
            {
                discount = 0.25;
            }

            if (seamen % 2 == 0 && season != "Autumn")
            {
                double discountTwo = totalPrice * 0.05;
                totalPrice = totalPrice - discountTwo;
            }

            double finalPrice = totalPrice - (totalPrice * discount);

            if (budget >= finalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - finalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalPrice - budget:f2} leva.");
            }

        }
    }
}
