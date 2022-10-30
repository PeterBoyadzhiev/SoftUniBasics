using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryNumber = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();

            double totalGrade = 0;
            double presentations = 0;

            while (nameOfPresentation != "Finish")
            {
                double averageGrade = 0;
                
                for (int grade = 1; grade <= juryNumber; grade++)
                {
                    double score = double.Parse(Console.ReadLine());
                    averageGrade += score / juryNumber;
                }
                Console.WriteLine($"{nameOfPresentation} - {averageGrade:f2}.");

                presentations++;

                totalGrade += averageGrade;

                nameOfPresentation = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {(totalGrade / presentations):f2}.");
        }
    }
}
