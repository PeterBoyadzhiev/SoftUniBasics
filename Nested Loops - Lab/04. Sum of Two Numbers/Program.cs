using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int comboCounter = 0;
            int sum = 0;

            for (int number1 = start; number1 <= end; number1++)
            {
                for (int number2 = start; number2 <= end; number2++)
                {
                    comboCounter++;
                    sum = number1 + number2;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{comboCounter} ({number1} + {number2} = {magicNumber})");
                        break;
                    }
                }

                if (sum == magicNumber)
                {
                    break;
                }
            }

            if (sum != magicNumber)
            {
                Console.WriteLine($"{comboCounter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
