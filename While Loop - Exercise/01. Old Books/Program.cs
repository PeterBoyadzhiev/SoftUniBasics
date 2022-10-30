using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            string checkBook = Console.ReadLine();

            int booksChecked = 0;

            while (checkBook != "No More Books")
            {
                if (checkBook == favBook)
                {
                    Console.WriteLine($"You checked {booksChecked} books and found it.");
                    break;
                }
                else
                {
                    booksChecked++;
                    checkBook = Console.ReadLine();
                }
            }
            if (checkBook == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {booksChecked} books.");
            }
        }
    }
}
