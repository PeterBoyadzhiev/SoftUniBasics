using System;

namespace _05.CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int wordLength = text.Length;

            for (int i = 0; i < wordLength; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
