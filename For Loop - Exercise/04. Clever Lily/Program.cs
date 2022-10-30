using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceForMachine = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());

            int toysCount = 0;
            double savedMoney = 0;
            double moneyPerBirthday = 0;

            for (int year = 1; year <= age; year++)
            {
                if (year % 2 == 0)
                {
                    moneyPerBirthday += 10.00;
                    savedMoney += moneyPerBirthday -1;
                }
                else
                {
                    toysCount++;
                }
            }

            double toysTotalPrice = pricePerToy * toysCount;
            double allMoneySaved = toysTotalPrice + savedMoney;

            if (allMoneySaved >= priceForMachine)
            {
                Console.WriteLine($"Yes! {(allMoneySaved - priceForMachine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceForMachine - allMoneySaved):f2}");
            }
        }
    }
}
