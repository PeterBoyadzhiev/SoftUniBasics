using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();
            double annualGrade = double.Parse(Console.ReadLine());
            double sumOfGrades = 0;
            int grade = 1;
            int failCounter = 0;

            while (grade <= 12)
            {
                if (annualGrade < 4.00)
                {
                    failCounter++;

                    if (failCounter >= 2)
                    {
                        Console.WriteLine($"{nameOfStudent} has been excluded at {grade} grade");
                        break;
                    }
                    else
                    {
                        annualGrade = double.Parse(Console.ReadLine());
                        continue;
                    }
                    
                }
                else
                {
                    sumOfGrades += annualGrade;
                    
                    if (grade < 12)
                    {
                        grade++;
                        annualGrade = double.Parse(Console.ReadLine()); 
                    }
                    else
                    {
                        Console.WriteLine($"{nameOfStudent} graduated. Average grade: {(sumOfGrades / grade):f2}");
                        break;
                    }
                }
             }
        }
    }
}
