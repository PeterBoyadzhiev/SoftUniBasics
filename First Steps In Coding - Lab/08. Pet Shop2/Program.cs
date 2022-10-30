using System;

namespace _08._Pet_Shop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int DogFood = int.Parse(Console.ReadLine());
            int CatFood = int.Parse(Console.ReadLine());
            double DogFoodPrice = 2.50;
            double CatFoodPrice = 4;
            double DogFoodTotalPrice = DogFood * DogFoodPrice;
            double CatFoodTotalPrice = CatFood * CatFoodPrice;
            double Total = DogFoodTotalPrice + CatFoodTotalPrice;
            Console.WriteLine($"{Total} lv.");
        }
    }
}
