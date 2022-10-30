using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пол   Gym Boxing Yoga    Zumba Dances  Pilates
            //мъж	$42 $41     $45     $34  $51     $39
            //жена  $35 $37     $42     $31  $53     $37


            double budget = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double price = 0;

            switch (sport)
            {
                case "Gym":
                    switch (sex)
                    {
                        case "m":
                            price = 42;
                            break;
                        case "f":
                            price = 35;
                            break;
                    }

                    break;
                case "Boxing":
                    switch (sex)
                    {
                        case "m":
                            price = 41;
                            break;
                        case "f":
                            price = 37;
                            break;
                    }
                    break;
                case "Yoga":
                    switch (sex)
                    {
                        case "m":
                            price = 45;
                            break;
                        case "f":
                            price = 42;
                            break;
                    }
                    break;
                case "Zumba":
                    switch (sex)
                    {
                        case "m":
                            price = 34;
                            break;
                        case "f":
                            price = 31;
                            break;
                    }
                    break;
                case "Dances":
                    switch (sex)
                    {
                        case "m":
                            price = 51;
                            break;
                        case "f":
                            price = 53;
                            break;
                    }
                    break;
                case "Pilates":
                    switch (sex)
                    {
                        case "m":
                            price = 39;
                            break;
                        case "f":
                            price = 37;
                            break;
                    }
                    break;
            }

            if (age <= 19)
            {
                price *= 0.8;
            }

            if (budget >= price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(price - budget):f2} more.");
            }
        }
    }
}
