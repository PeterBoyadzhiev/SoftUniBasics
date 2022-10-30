using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysToRead = int.Parse(Console.ReadLine());

            int days = (pages / pagesPerHour) / daysToRead;

            Console.WriteLine(days);
        }
    }
}
