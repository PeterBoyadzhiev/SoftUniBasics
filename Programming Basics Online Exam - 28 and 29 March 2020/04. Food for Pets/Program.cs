using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            int biscuitCounter = 0;
            double totalDogFood = 0;
            double totalCatFood = 0;
            double totalBiscuits = 0;
            double accumulatedBiscuits = 0;


            for (int i = 1; i <= days; i++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());

                totalDogFood += dogFood;
                totalCatFood += catFood;

                if (i % 3 == 0)
                {
                    totalBiscuits = (dogFood + catFood) * 0.1;
                    accumulatedBiscuits += totalBiscuits;
                }
            }

            double totalFoodEaten = totalDogFood + totalCatFood;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(accumulatedBiscuits)}gr.");
            Console.WriteLine($"{((totalDogFood + totalCatFood) / food * 100):f2}% of the food has been eaten.");
            Console.WriteLine($"{(totalDogFood / totalFoodEaten * 100):f2}% eaten from the dog.");
            Console.WriteLine($"{(totalCatFood / totalFoodEaten * 100):f2}% eaten from the cat.");
        }
    }
}
