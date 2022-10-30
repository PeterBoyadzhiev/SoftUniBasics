using System;

namespace _01.ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            const double EXCELLENT_GRADE = 5.5;
            //Read input grade from customer
            double currentGrade = double.Parse(Console.ReadLine());
            //check if the grade is excellent
            bool isExcellentGrade = currentGrade >= EXCELLENT_GRADE;
            
                if (isExcellentGrade)
            {
                //Print the result
                Console.WriteLine("Excellent!");
            }
        }
    }
}
