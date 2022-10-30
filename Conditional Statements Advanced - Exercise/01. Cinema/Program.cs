using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double profit = 0;

            switch (type)
            {
                case "Premiere":
                    profit = rows * columns * 12;
                    break;
                case "Normal":
                    profit = rows * columns * 7.5;
                    break;
                case "Discount":
                    profit = rows * columns * 5;
                    break;
            }

            Console.WriteLine($"{profit:f2} leva");
        }
    }
}
