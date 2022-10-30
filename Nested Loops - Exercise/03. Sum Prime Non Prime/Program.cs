using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;

            while (input != "stop")
            {
                int numbers = int.Parse(input);

                if (numbers < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                int prime = 0;

                for (int i = 1; i <= numbers; i++)
                {
                    if (numbers % i == 0)
                    {
                        prime++;
                    }
                    
                }

                if (prime == 2)
                {
                    sumPrime += numbers;
                }
                else
                {
                    sumNonPrime += numbers;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
