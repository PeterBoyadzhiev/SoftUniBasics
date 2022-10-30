using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            int climbersOfMusalaGroups = 0;
            int climbersOfMonblanGroups = 0;
            int climbersOfKiliGroups = 0;
            int climbersOfK2Groups = 0;
            int climbersOfEverestGroups = 0;

            int totalClimbers = 0;

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            for (int group = 1; group <= numberOfGroups; group++)
            {
                int numberOfClimbersInGroup = int.Parse(Console.ReadLine());

                if (numberOfClimbersInGroup > 0 && numberOfClimbersInGroup <= 5)
                {
                    climbersOfMusalaGroups += numberOfClimbersInGroup;
                }
                else if (numberOfClimbersInGroup > 5 && numberOfClimbersInGroup <= 12)
                {
                    climbersOfMonblanGroups += numberOfClimbersInGroup;
                }
                else if (numberOfClimbersInGroup > 12 && numberOfClimbersInGroup <= 25)
                {
                    climbersOfKiliGroups += numberOfClimbersInGroup;
                }
                else if (numberOfClimbersInGroup > 25 && numberOfClimbersInGroup <= 40)
                {
                    climbersOfK2Groups += numberOfClimbersInGroup;
                }
                else if (numberOfClimbersInGroup > 40)
                {
                    climbersOfEverestGroups += numberOfClimbersInGroup;
                }

                totalClimbers += numberOfClimbersInGroup;

            }

            p1 = climbersOfMusalaGroups * 1.0 / totalClimbers * 100;
            p2 = climbersOfMonblanGroups * 1.0 / totalClimbers * 100;
            p3 = climbersOfKiliGroups * 1.0 / totalClimbers * 100;
            p4 = climbersOfK2Groups * 1.0 / totalClimbers * 100;
            p5 = climbersOfEverestGroups * 1.0 / totalClimbers * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
