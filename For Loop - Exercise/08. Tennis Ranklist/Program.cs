using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int accumulatedPoints = startingPoints;
            int wonTournaments = 0;

            for (int tournament = 1; tournament <= numberOfTournaments; tournament++)
            {
                string placement = Console.ReadLine();

                switch (placement)
                {
                    case "W":
                        accumulatedPoints += 2000;
                        wonTournaments++;
                        break;
                    case "F":
                        accumulatedPoints += 1200;
                        break;
                    case "SF":
                        accumulatedPoints += 720;
                        break;
                }
            }

            Console.WriteLine($"Final points: {accumulatedPoints}");
            Console.WriteLine($"Average points: {Math.Floor((accumulatedPoints - startingPoints) * 1.0 / numberOfTournaments)}");
            Console.WriteLine($"{(wonTournaments * 1.0 / numberOfTournaments * 100):f2}%");
        }
    }
}
