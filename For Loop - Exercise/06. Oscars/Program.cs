using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int countOfGraders = int.Parse(Console.ReadLine());

            double actorPoints = 0;
            double totalPoints = pointsFromAcademy;

            for (int grader = 1; grader <= countOfGraders; grader++)
            {
                string nameOfGrader = Console.ReadLine();
                double pointsFromGrader = double.Parse(Console.ReadLine());

                int nameOfGraderPoints = nameOfGrader.Length;
                actorPoints = nameOfGraderPoints * pointsFromGrader / 2;
                totalPoints += actorPoints;

                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {totalPoints:f1}!");
                    break;
                }
            }

            if (totalPoints <= 1250.5)
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - totalPoints:f1} more!");
            }
        }
    }
}
