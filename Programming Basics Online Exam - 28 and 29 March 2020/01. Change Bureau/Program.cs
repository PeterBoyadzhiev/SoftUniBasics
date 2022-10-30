using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            //double lev = 1;
            //double bitcoin = lev * 1168;
            //double dollar = lev * 1.76;
            //double uan = dollar * 0.15;
            //double euro = lev * 1.95;

            int bitcoinAmount = int.Parse(Console.ReadLine());
            double uanAmount = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double commissionInPercent = commission / 100;
            double totalMoneyNoCommission = ((bitcoinAmount * 1168) / 1.95) + (((uanAmount * 0.15) * 1.76) / 1.95);
            double commissionFinal = totalMoneyNoCommission * commissionInPercent;
            double totalMoney = totalMoneyNoCommission - commissionFinal;
           

            Console.WriteLine($"{totalMoney:f2}");

        }
    }
}
