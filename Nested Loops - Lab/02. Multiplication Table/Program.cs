using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int multiplierOne = 1; multiplierOne <= 10; multiplierOne++)
            {
                for (int multiplierTwo = 1; multiplierTwo <= 10; multiplierTwo++)
                {
                    Console.WriteLine($"{multiplierOne} * {multiplierTwo} = {multiplierOne*multiplierTwo}");
                }
            }
        }
    }
}
