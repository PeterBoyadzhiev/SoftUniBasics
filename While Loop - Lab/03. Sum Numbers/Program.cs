using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalNumber = int.Parse(Console.ReadLine());
            int randomNumbers = int.Parse(Console.ReadLine());

            int sum = 0;

            while (sum < finalNumber)
            {
                sum += randomNumbers;

                if (sum >= finalNumber)
                {
                    break;
                }
                else
                {
                    randomNumbers = int.Parse(Console.ReadLine());
                }
                
            }

            Console.WriteLine(sum);
        }
    }
}
