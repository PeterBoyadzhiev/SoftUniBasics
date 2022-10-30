using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int facebookPrice = 150;
            int instagramPrice = 100;
            int redditPrice = 50;

            int tabsOpen = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int tabs = 1; tabs <= tabsOpen; tabs++)
            {
                string tabType = Console.ReadLine();

                switch (tabType)
                {
                    case "Facebook":
                        salary -= facebookPrice;
                        break;
                    case "Instagram":
                        salary -= instagramPrice;
                        break;
                    case "Reddit":
                        salary -= redditPrice;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
