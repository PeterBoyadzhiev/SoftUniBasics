using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCycles = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sumOfNumbers = 0;

            for (int number = 1; number <= countOfCycles; number++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }

                sumOfNumbers += currentNumber;
            }

            int sumWithoutMax = sumOfNumbers - maxNumber;

            if (sumWithoutMax == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumWithoutMax - maxNumber)}");
            }
        }
    }
}
