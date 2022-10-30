using System;

namespace _05.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {

            double penPrice = 5.80;
            double markersPrice = 7.20;
            double cleanerPrice = 1.20;

            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int litersCleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double allPenPrice = pens * penPrice;
            double allMarkersPrice = markers * markersPrice;
            double allCleanerPrice = litersCleaner * cleanerPrice;
            double sum = allPenPrice + allMarkersPrice + allCleanerPrice;
            double discountedSum = sum - (sum * discount / 100);

            Console.WriteLine(discountedSum);

        }
    }
}
