using System;

namespace _02.NumbersN1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int n = number; n >= 1; n--)
            {
                Console.WriteLine(n);
            }
        }
    }
}
