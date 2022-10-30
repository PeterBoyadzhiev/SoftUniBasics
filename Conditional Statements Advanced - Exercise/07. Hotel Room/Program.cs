using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;
            double totalPriceStudio = 0;
            double totalPriceApartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceApartment = 65;
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceApartment = 68.70;
                    break;
                case "July":
                case "August":
                    priceStudio = 76;
                    priceApartment = 77;
                    break;
            }
            totalPriceStudio = nights * priceStudio;
            totalPriceApartment = nights * priceApartment;

            if (nights > 7 && nights <= 14)
            {
                if (month == "May" || month == "October")
                {
                    totalPriceStudio *= 0.95;
                }
            }
            else if (nights > 14)
            {
                totalPriceApartment *= 0.9;

                if (month == "May" || month == "October")
                {
                    totalPriceStudio *= 0.7;
                }
                else if (month == "June" || month == "September")
                {
                    totalPriceStudio *= 0.8;
                }
            }

            Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
        }
    }
}
