using System;

namespace _03._Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            int daysStay = nights - 1;

            double price = 0;

            if (daysStay < 10)
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        price = daysStay * 18;
                        break;

                    case "apartment":
                        price = daysStay * 25 * 0.7;
                        break;

                    case "president apartment":
                        price = daysStay * 35 * 0.9;
                        break;
                }
            }
            else if (daysStay >= 10 && daysStay <= 15)
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        price = daysStay * 18;
                        break;

                    case "apartment":
                        price = daysStay * 25 * 0.65;
                        break;

                    case "president apartment":
                        price = daysStay * 35 * 0.85;
                        break;
                }
            }
            else if (daysStay > 15)
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        price = daysStay * 18;
                        break;

                    case "apartment":
                        price = daysStay * 25 * 0.5;
                        break;

                    case "president apartment":
                        price = daysStay * 35 * 0.8;
                        break;
                }
            }

            if (rating == "positive")
            {
                price *= 1.25;
            }
            else if (rating == "negative")
            {
                price *= 0.9;
            }
            Console.WriteLine($"{price:f2}");

        }
    }
}
