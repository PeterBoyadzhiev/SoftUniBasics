using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sumOfCoins = 0;

            while (input != "Start")
            {

                double coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sumOfCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }
            string input2;
            double price = 0;
            double change = sumOfCoins;

            while ((input2 = Console.ReadLine()) != "End")
            {
                
                if (input2 == "Nuts")
                {
                    price = 2;
                    if (price > change)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    change -= price;
                    Console.WriteLine($"Purchased nuts");
                }
                else if (input2 == "Water")
                {
                    price = 0.7;
                    if (price > change)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    change -= price;
                    Console.WriteLine($"Purchased water");
                }
                else if (input2 == "Crisps")
                {
                    price = 1.5;
                    if (price > change)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    change -= price;
                    Console.WriteLine($"Purchased crisps");
                }
                else if (input2 == "Soda")
                {
                    price = 0.8;
                    if (price > change)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    change -= price;
                    Console.WriteLine($"Purchased soda");
                }
                else if (input2 == "Coke")
                {
                    price = 1;
                    if (price > change)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    change -= price;
                    Console.WriteLine($"Purchased coke");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }

            Console.WriteLine($"Change: {change:f2}");
        }
    }
}
