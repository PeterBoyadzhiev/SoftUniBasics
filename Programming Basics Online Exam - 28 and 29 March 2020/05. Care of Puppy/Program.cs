using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKilos = int.Parse(Console.ReadLine());
            int food = foodInKilos * 1000;
            int totalFoodEaten = 0;

            string input = Console.ReadLine();

            while (input != "Adopted")
            {
                int foodEaten = int.Parse(input);
                totalFoodEaten += foodEaten;

                input = Console.ReadLine();
            }

            if (totalFoodEaten <= food)
            {
                Console.WriteLine($"Food is enough! Leftovers: {food - totalFoodEaten} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFoodEaten - food} grams more.");
            }
        }
    }
}
