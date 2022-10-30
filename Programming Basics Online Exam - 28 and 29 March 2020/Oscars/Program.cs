using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statues = rent * 0.7;
            double catering = statues * 0.85;
            double sound = catering * 0.5;

            double fullCost = statues + catering + sound + rent;

            Console.WriteLine(fullCost);
        }
    }
}
