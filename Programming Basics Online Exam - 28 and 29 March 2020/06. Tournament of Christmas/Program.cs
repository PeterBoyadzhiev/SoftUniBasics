using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int daysWon = 0;
            int daysLost = 0;
            double totalWinnings = 0;

            for (int i = 1; i <= days; i++)
            {
                string sport = Console.ReadLine();
                double dailyWinnings = 0;
                int wonGames = 0;
                int lostGames = 0;

                while (sport != "Finish")
                {
                    string input = Console.ReadLine();

                    if (input == "win")
                    {
                        dailyWinnings += 20;
                        wonGames++;
                    }
                    else if (input == "lose")
                    {
                        lostGames++;
                    }



                    sport = Console.ReadLine();
                }

                if (wonGames > lostGames)
                {
                    dailyWinnings *= 1.1;
                    daysWon++;
                    totalWinnings += dailyWinnings;
                }
                else
                {
                    daysLost++;
                    totalWinnings += dailyWinnings;
                }
            }

            if (daysWon > daysLost)
            {
                totalWinnings *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalWinnings:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalWinnings:f2}");
            }
        }
    }
}
