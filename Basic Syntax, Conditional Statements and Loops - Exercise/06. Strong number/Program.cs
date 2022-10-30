using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int lastDigit = 0;
            
            int factorialSum = 0;

            while (numberCopy != 0)
            {
                int factorial = 1;
                lastDigit = numberCopy % 10;
                numberCopy /= 10;
                for (int i = 1; i <= lastDigit; i++)
                {
                    factorial *= i;

                }

                factorialSum += factorial;
            }

            if (factorialSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
