using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            double cost = 0;


            switch (fruit)
            {
                case "Watermelon":
                    switch (size)
                    {
                        case "small":
                            cost = 2 * 56;
                            break;
                        case "big":
                            cost = 5 * 28.70;
                            break;
                    }
                    break;
                case "Mango":
                    switch (size)
                    {
                        case "small":
                            cost = 2 * 36.66;
                            break;
                        case "big":
                            cost = 5 * 19.60;
                            break;
                    }
                    break;
                case "Pineapple":
                    switch (size)
                    {
                        case "small":
                            cost = 2 * 42.10;
                            break;
                        case "big":
                            cost = 5 * 24.80;
                            break;
                    }
                    break;
                case "Raspberry":
                    switch (size)
                    {
                        case "small":
                            cost = 2 * 20;
                            break;
                        case "big":
                            cost = 5 * 15.20;
                            break;
                    }
                    break;
            }

            double total = amount * cost;

            if (amount * cost >= 400 && amount * cost <= 1000)
            {
                total *= 0.85;
            }
            else if (amount * cost > 1000)
            {
                total *= 0.5;
            }


            Console.WriteLine($"{(total):f2} lv.");
        }
    }
}
