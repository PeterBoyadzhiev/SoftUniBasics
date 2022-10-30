using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < 2 * count; i++)
            {
                int Number = int.Parse(Console.ReadLine());

                if (i < count)
                {
                    sumLeft += Number;
                }
                else
                {
                    sumRight += Number;
                }
            }

            int totalSum = 0;
            int totalDifference = 0;

            if (sumLeft == sumRight)
            {
                totalSum = sumLeft;
                Console.WriteLine($"Yes, sum = {totalSum}");
            }
            else if (sumLeft != sumRight)
            {
                totalDifference = Math.Abs(sumLeft - sumRight);
                Console.WriteLine($"No, diff = {totalDifference}");
            }
        }
    }
}
