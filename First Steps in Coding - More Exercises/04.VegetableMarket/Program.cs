using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double veggiePricePerKilo = double.Parse(Console.ReadLine());
            double fruitPricePerKilo = double.Parse(Console.ReadLine());
            int veggieKilos = int.Parse(Console.ReadLine());
            int fruitKilos = int.Parse(Console.ReadLine());

            double fullPriceInLev = (veggiePricePerKilo * veggieKilos) + (fruitPricePerKilo * fruitKilos);
            double fullPriceInEuro = fullPriceInLev / 1.94;

            Console.WriteLine($"{fullPriceInEuro:f2}");
        }
    }
}
