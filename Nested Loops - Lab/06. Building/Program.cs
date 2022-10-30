using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int apartments = int.Parse(Console.ReadLine());

            for (int currentFloor = floors; currentFloor >= 1; currentFloor--)
            {
                for (int currentApartment = 0; currentApartment < apartments; currentApartment++)
                {
                    if (currentFloor == floors)
                    {
                        Console.Write($"L{currentFloor}{currentApartment} ");
                    }
                    else if (currentFloor % 2 == 0)
                    {
                        Console.Write($"O{currentFloor}{currentApartment} ");
                    }
                    else
                    {
                        Console.Write($"A{currentFloor}{currentApartment} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
