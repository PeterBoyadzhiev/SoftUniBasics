using System;

namespace _09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double volumeInLiters = volume * 0.001;
            double spaceTaken = percent /  100;
            double liters = volumeInLiters * (1 - spaceTaken);

            Console.WriteLine(liters);
        }
    }
}
