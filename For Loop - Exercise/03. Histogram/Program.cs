using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;

            for (int i = 1; i <= cycles; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers < 200)
                {
                    count1++;
                }
                else if (numbers >= 200 && numbers < 400)
                {
                    count2++;
                }
                else if (numbers >= 400 && numbers < 600)
                {
                    count3++;
                }
                else if (numbers >= 600 && numbers < 800)
                {
                    count4++;
                }
                else if (numbers >= 800)
                {
                    count5++;
                }
             }

            double p1 = (double)count1 / cycles * 100;
            double p2 = (double)count2 / cycles * 100;
            double p3 = (double)count3 / cycles * 100;
            double p4 = (double)count4 / cycles * 100;
            double p5 = (double)count5 / cycles * 100;


            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
