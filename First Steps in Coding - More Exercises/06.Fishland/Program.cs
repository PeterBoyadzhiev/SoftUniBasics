using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKilos = double.Parse(Console.ReadLine());
            double safridKilos = double.Parse(Console.ReadLine());
            int midiKilos = int.Parse(Console.ReadLine());

            double palamudPrice = skumriqPrice * 1.6;
            double safridPrice = cacaPrice * 1.8;

            double palamudFinalPrice = palamudKilos * palamudPrice;
            double safridFinalPrice = safridKilos * safridPrice;
            double midiFinalPrice = midiKilos * 7.5;

            double total = palamudFinalPrice + safridFinalPrice + midiFinalPrice;

            Console.WriteLine($"{total:F2}");



        }
    }
}
