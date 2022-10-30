using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumberOfPoorGrades = int.Parse(Console.ReadLine());

            string nameOfProblem = Console.ReadLine();

            int sumOfGrades = 0;
            int numberOfProblems = 0;

            int numberOfPoorGrades = 0;
            string lastProblem = "";

            while (nameOfProblem != "Enough")
            {
                int scoreForProblem = int.Parse(Console.ReadLine());

                sumOfGrades += scoreForProblem;
                numberOfProblems++;
                lastProblem = nameOfProblem;

                if (scoreForProblem <= 4)
                {
                    numberOfPoorGrades++;
                }
                if (numberOfPoorGrades >= maxNumberOfPoorGrades)
                {
                    Console.WriteLine($"You need a break, {numberOfPoorGrades} poor grades.");
                    break;
                }
                nameOfProblem = Console.ReadLine();

                if (nameOfProblem == "Enough")
                {
                    Console.WriteLine($"Average score: {((double)sumOfGrades / numberOfProblems):f2}");
                    Console.WriteLine($"Number of problems: {numberOfProblems}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                }
            }
        }
    }
}
