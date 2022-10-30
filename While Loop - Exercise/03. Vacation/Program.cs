using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int daysOfSpending = 0;
            int totalDays = 0;

            double savedMoney = availableMoney;

            while (savedMoney < neededMoney)
            {
                string action = Console.ReadLine();
                double change = double.Parse(Console.ReadLine());

                totalDays++;

                if (action == "spend")
                {
                    savedMoney -= change;
                    daysOfSpending++;

                    if (savedMoney < 0)
                    {
                        savedMoney = 0;
                    }

                    if (daysOfSpending == 5)
                    {
                        break;
                    }
                   
                }
                else if (action == "save")
                {
                    savedMoney += change;
                    daysOfSpending = 0;
                }   
            }

            if (daysOfSpending == 5 || neededMoney > savedMoney)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{totalDays}");
            }

            if (savedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
        }
    }
}
