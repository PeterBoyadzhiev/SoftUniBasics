using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            for (int rows = 1; rows <= number; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    if (currentNumber > number)
                    {
                        break;
                    }

                    Console.Write($"{currentNumber} ");

                    currentNumber++;
                }

                Console.WriteLine();

                if (currentNumber > number)
                {
                    break;
                }
            }
        }
    }
}
