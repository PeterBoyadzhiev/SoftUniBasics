using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();


            while (country != "End")
            {
                double moneyNeeded = double.Parse(Console.ReadLine());
                double moneySaved = 0;

                while (moneySaved < moneyNeeded)
                {
                    double income = double.Parse(Console.ReadLine());

                    moneySaved += income;
                }

                Console.WriteLine($"Going to {country}!");

                country = Console.ReadLine();
            }
        }
    }
}
