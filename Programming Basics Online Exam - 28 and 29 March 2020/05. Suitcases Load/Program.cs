using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            double totalSize = 0;
            int suitcases = 0;

            while (input != "End")
            {
                double suitcaseSize = double.Parse(input);

                suitcases++;

                if (suitcases % 3 == 0)
                {
                    suitcaseSize *= 1.1;
                }

                totalSize += suitcaseSize;

                if (capacity - totalSize < 0)
                {
                    Console.WriteLine("No more space!");
                    suitcases--;
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {suitcases} suitcases loaded.");
        }
    }
}
