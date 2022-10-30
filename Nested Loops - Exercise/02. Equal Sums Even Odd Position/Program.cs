using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            for (int numbers = numberOne; numbers <= numberTwo; numbers++)
            {
                string currentNum = numbers.ToString();
                int sumOdd = 0;
                int sumEven = 0;

                for (int position = 0; position < currentNum.Length; position++)
                {
                    int currentDigit = int.Parse(currentNum[position].ToString());

                    if (position % 2 == 0)
                    {
                        sumEven += currentDigit;
                    }
                    else
                    {
                        sumOdd += currentDigit;
                    }
                }

                if (sumOdd == sumEven)
                {
                    Console.Write($"{numbers} ");
                }
            }
        }
    }
}
