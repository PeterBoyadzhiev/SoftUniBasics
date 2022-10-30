using System;

namespace _04._Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComputers = int.Parse(Console.ReadLine());
            double individualRating = 0;
            double possibleSales = 0;
            double sales = 0;
            double allRatings = 0;
            double totalSales = 0;

            for (int i = 1; i <= numberOfComputers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                individualRating = number % 10;
                possibleSales = number / 10;

                allRatings += individualRating;


                if (individualRating == 2)
                {
                    sales = 0;
                }
                else if (individualRating == 3)
                {
                    sales = possibleSales * 0.5;
                }
                else if (individualRating == 4)
                {
                    sales = possibleSales * 0.7;
                }
                else if (individualRating == 5)
                {
                    sales = possibleSales * 0.85;
                }
                else if (individualRating == 6)
                {
                    sales = possibleSales;
                }

                totalSales += sales;
            }

            Console.WriteLine($"{totalSales:f2}");
            Console.WriteLine($"{(allRatings / numberOfComputers):f2}");

        }
    }
}
