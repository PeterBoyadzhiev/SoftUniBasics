using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int pieces = width * length;

            while (pieces >= 0)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }
                else
                {
                    int piecesTaken = int.Parse(input);
                    pieces -= piecesTaken;
                }

            }

            if (pieces > 0)
                    {
                Console.WriteLine($"{pieces} pieces are left.");
            }
            if (pieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");	
            }
        }
    }
}
