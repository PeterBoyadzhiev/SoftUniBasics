using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesOfWalking = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            int caloriesTaken = int.Parse(Console.ReadLine());

            int caloriesBurned = times * minutesOfWalking * 5;

            if (caloriesBurned >= caloriesTaken * 0.5)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }
        }
    }
}
