using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfMovie = Console.ReadLine();

            double studentTickets = 0;
            double standardTickets = 0;
            double kidsTickets = 0;
            double allTickets = 0;

            while (nameOfMovie != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                double seatsTaken = 0;

                while (seatsTaken < freeSeats)
                {
                    string ticket = Console.ReadLine();

                    if (ticket == "End")
                    {
                        break;
                    }
                    else if (ticket == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticket == "standard")
                    {
                        standardTickets++;
                    }
                    else if (ticket == "kid")
                    {
                        kidsTickets++;
                    }

                    seatsTaken++;

                    allTickets++;

                }

                Console.WriteLine($"{nameOfMovie} - {(seatsTaken / freeSeats * 100):f2}% full.");

                nameOfMovie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{(studentTickets / allTickets * 100):f2}% student tickets.");
            Console.WriteLine($"{(standardTickets / allTickets * 100):f2}% standard tickets.");
            Console.WriteLine($"{(kidsTickets / allTickets * 100):f2}% kids tickets.");
        }
    }
}
