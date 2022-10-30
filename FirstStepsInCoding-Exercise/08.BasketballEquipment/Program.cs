using System;

namespace _08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualPrice = int.Parse(Console.ReadLine());

            double shoes = annualPrice * 0.6;
            double jersey = shoes * 0.8;
            double ball = jersey * 0.25;
            double accessories = ball * 0.2;

            double finalPrice = annualPrice + shoes + jersey + ball + accessories;

            Console.WriteLine(finalPrice);
        }
    }
}
