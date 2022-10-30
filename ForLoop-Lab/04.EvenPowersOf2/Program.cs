using System;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = 0;

            for (int i = 2; Math.Pow(i,power) <= Math.Pow(i,number); power = power + 2)
            {
                Console.WriteLine(Math.Pow(i, power));
            }
        }
    }
}
