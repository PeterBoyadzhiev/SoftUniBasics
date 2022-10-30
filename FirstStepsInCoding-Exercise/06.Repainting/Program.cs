using System;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylonPricePerMeter = 1.50;
            double paintPricePerLiter = 14.50;
            double thinnerPricePerLiter = 5;
            double bagPrice = 0.4;

            int nylonMeters = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int thinnerLiters = int.Parse(Console.ReadLine());
            int hoursWorker = int.Parse(Console.ReadLine());

            double nylonFinalPrice = (nylonMeters + 2) * nylonPricePerMeter;
            double paintFinalPrice = (paintLiters + paintLiters * 0.1) * paintPricePerLiter;
            double thinnerFinalPrice = thinnerLiters * thinnerPricePerLiter;
            double sumMaterial = nylonFinalPrice + paintFinalPrice + thinnerFinalPrice + bagPrice;
            double sumWorker = hoursWorker * (sumMaterial * 0.3);
            double finalSum = sumMaterial + sumWorker;

            Console.WriteLine(finalSum);

        }
    }
}
