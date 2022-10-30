using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * length * height;

            int boxSize = 1 * 1 * 1;
            int boxes = 0;
            int spaceTaken = 0;

            
            while (spaceTaken <= volume)
            {
                string input = Console.ReadLine();

                

                if (input == "Done")
                {
                    break;
                }
                else
                {
                    int boxesMoved = int.Parse(input);
                    boxes += boxesMoved;
                    spaceTaken = boxes * boxSize;
                }
            }

            if (volume > spaceTaken)
            {
                Console.WriteLine($"{Math.Abs(spaceTaken - volume)} Cubic meters left.");
            }
            if (spaceTaken > volume)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(spaceTaken - volume)} Cubic meters more.");
            }

        }
    }
}
