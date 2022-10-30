using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double cost = 0;

            switch (typeOfFlowers)
            {
                case "Roses":
                    if (numberOfFlowers > 80)
                    {
                        cost = numberOfFlowers * 5 * 0.9;
                    }
                    else
                    {
                        cost = numberOfFlowers * 5;
                    }
                    break;
                case "Dahlias":
                    if (numberOfFlowers > 90)
                    {
                        cost = numberOfFlowers * 3.8 * 0.85;
                    }
                    else
                    {
                        cost = numberOfFlowers * 3.8;
                    }
                    break;
                case "Tulips":
                    if (numberOfFlowers > 80)
                    {
                        cost = numberOfFlowers * 2.8 * 0.85;
                    }
                    else
                    {
                        cost = numberOfFlowers * 2.8;
                    }
                    break;
                case "Narcissus":
                    if (numberOfFlowers < 120)
                    {
                        cost = numberOfFlowers * 3 * 1.15;
                    }
                    else
                    {
                        cost = numberOfFlowers * 3;
                    }
                    break;
                case "Gladiolus":
                    if (numberOfFlowers < 80)
                    {
                        cost = numberOfFlowers * 2.5 * 1.20;
                    }
                    else
                    {
                        cost = numberOfFlowers * 2.5;
                    }
                    break;
            }
            if (cost <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {budget - cost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {cost - budget:f2} leva more.");
            }
        }
    }
}
