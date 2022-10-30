using System;

namespace _01._PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceCpu = double.Parse(Console.ReadLine());
            double priceGpu = double.Parse(Console.ReadLine());
            double priceRam = double.Parse(Console.ReadLine());
            int amountRam = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double priceCpuInLeva = (priceCpu * 1.57) - (priceCpu * 1.57 * discount);
            double priceGpuInLeva = (priceGpu * 1.57) - (priceGpu * 1.57 * discount);
            double priceRamInLeva = priceRam * 1.57 * amountRam;

            double totalSum = priceCpuInLeva + priceGpuInLeva + priceRamInLeva;

            Console.WriteLine($"Money needed - {totalSum:f2} leva.");

        }
    }
}
