using System;

namespace _04.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PASSWORD = "s3cr3t!P@ssw0rd";

            string password = Console.ReadLine();

            if (password == PASSWORD)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
