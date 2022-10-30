using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            double musalaClimbers = 0;
            double monblanClimbers = 0;
            double kiliClimbers = 0;
            double k2Climbers = 0;
            double everestClimbers = 0;


            for (int i = 1; i <= numberOfGroups; i++)
            {
                int numberOfPeopleInGroup = int.Parse(Console.ReadLine());

                if (numberOfPeopleInGroup <= 5)
                {
                    musalaClimbers += numberOfPeopleInGroup;

                }
                else if (numberOfPeopleInGroup >= 6 && numberOfPeopleInGroup <= 12)
                {
                    monblanClimbers += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup >= 13 && numberOfPeopleInGroup <= 25)
                {
                    kiliClimbers += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup >= 26 && numberOfPeopleInGroup <= 40)
                {
                    k2Climbers += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup >= 41)
                {
                    everestClimbers += numberOfPeopleInGroup;
                }
            }

            double totalClimbers = musalaClimbers + monblanClimbers + kiliClimbers + k2Climbers + everestClimbers;

            Console.WriteLine($"{(musalaClimbers / totalClimbers * 100):f2}%");
            Console.WriteLine($"{(monblanClimbers / totalClimbers * 100):f2}%");
            Console.WriteLine($"{(kiliClimbers / totalClimbers * 100):f2}%");
            Console.WriteLine($"{(k2Climbers / totalClimbers * 100):f2}%");
            Console.WriteLine($"{(everestClimbers / totalClimbers * 100):f2}%");

        }
    }
}
