using System;

namespace _04._Sequence_2kplus1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i = i * 2 + 1)
            //{
            //    Console.WriteLine(i);
            //}

            int number = int.Parse(Console.ReadLine());

            int kNumber = 0;

            while (kNumber <= number)
            {
                kNumber = kNumber * 2 + 1;
                if (kNumber <= number)
                {
                    Console.WriteLine(kNumber);
                }
            }
        }
    }
}
