using System;

namespace _09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int stay = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string review = Console.ReadLine();
            double price = 0;

            int nights = stay - 1;

            if (nights < 10)
            {
                switch (room)
                {
                    case "room for one person":
                        price = nights * 18.00;
                        break;
                    case "apartment":
                        price = nights * 25.00 * 0.7;
                        break;
                    case "president apartment":
                        price = nights * 35.00 * 0.9;
                        break;
                }
            }
            else if (nights >= 10 && nights <= 15)
            {
                switch (room)
                {
                    case "room for one person":
                        price = nights * 18.00;
                        break;
                    case "apartment":
                        price = nights * 25.00 * 0.65;
                        break;
                    case "president apartment":
                        price = nights * 35.00 * 0.85;
                        break;
                }
            }
            else if (nights > 15)
            {
                switch (room)
                {
                    case "room for one person":
                        price = nights * 18.00;
                        break;
                    case "apartment":
                        price = nights * 25.00 * 0.5;
                        break;
                    case "president apartment":
                        price = nights * 35.00 * 0.8;
                        break;
                }
            }
            if (review == "positive")
            {
                price *= 1.25;
            }
            else if (review == "negative")
            {
                price *= 0.9;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
