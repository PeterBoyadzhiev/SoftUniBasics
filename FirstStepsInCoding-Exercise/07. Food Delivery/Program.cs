using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenPrice = 10.35;
            double fishPrice = 12.40;
            double veggiePrice = 8.15;
            double delivery = 2.50;

            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veggieMenu = int.Parse(Console.ReadLine());

            double chickenFinal = chickenMenu * chickenPrice;
            double fishFinal = fishMenu * fishPrice;
            double veggieFinal = veggieMenu * veggiePrice;
            double dessert = (chickenFinal + fishFinal + veggieFinal) * 0.2;
            double finalPrice = chickenFinal + fishFinal + veggieFinal + dessert + delivery;

            Console.WriteLine(finalPrice);
        }
    }
}
