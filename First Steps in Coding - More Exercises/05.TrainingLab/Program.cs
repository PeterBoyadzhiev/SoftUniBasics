using System;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightMeters = double.Parse(Console.ReadLine());
            double widthMeters = double.Parse(Console.ReadLine());
            double widthCm = widthMeters * 100;
            double heightCm = heightMeters * 100;
            double widthWoHall = widthCm - 100;
            double seatsWidth = Math.Floor (widthWoHall / 70);
            double seatsHeight = Math.Floor (heightCm / 120);
            double totalSeats = seatsHeight * seatsWidth - 3;

            Console.WriteLine(totalSeats);


        }
    }
}
