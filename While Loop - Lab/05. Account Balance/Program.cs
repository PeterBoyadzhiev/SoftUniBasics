using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;

            while (input != "NoMoreMoney")
            {
                double moneyIncrease = double.Parse(input);
                if (moneyIncrease >= 0)
                {
                    Console.WriteLine($"Increase: {moneyIncrease:f2}");
                    sum += moneyIncrease;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
