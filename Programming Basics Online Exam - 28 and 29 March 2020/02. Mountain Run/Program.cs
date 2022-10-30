using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentRecord = double.Parse(Console.ReadLine());
            double distanceToClimb = double.Parse(Console.ReadLine());
            double secondsToClimbMeter = double.Parse(Console.ReadLine());

            double backdraft = Math.Floor(distanceToClimb / 50) * 30;

            double totalTimeToClimb = distanceToClimb * secondsToClimbMeter + backdraft;

            if (totalTimeToClimb < currentRecord)
            {
                Console.WriteLine($"Yes! The new record is {totalTimeToClimb:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {Math.Abs(currentRecord - totalTimeToClimb):f2} seconds slower.");
            }
        }
    }
}
