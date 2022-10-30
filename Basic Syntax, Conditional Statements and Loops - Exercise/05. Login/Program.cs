using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char CurrentChar = username[i];
                password += CurrentChar;
            }

            string currentPassword = Console.ReadLine();
            int attempts = 0;

            while (currentPassword != password)
            {
                attempts++;

                if (attempts >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
                
                currentPassword = Console.ReadLine();
            }

            if (currentPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            
        }
    }
}
