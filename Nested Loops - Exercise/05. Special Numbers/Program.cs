using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int specialNumber = 1111; specialNumber <= 9999; specialNumber++)
            {
                string currentNumber = specialNumber.ToString();

                int prime = 0;

                for (int digit = 0; digit < currentNumber.Length; digit++)
                {
                    int currentDigit = int.Parse(currentNumber[digit].ToString());

                    if (currentDigit ==0)
                    {
                        continue;
                    }
                    if (number % currentDigit == 0)
                    {
                        prime++;
                    }
                }

                if (prime == currentNumber.Length)
                {
                    Console.Write($"{specialNumber} ");
                }
            }
        }
    }
}
