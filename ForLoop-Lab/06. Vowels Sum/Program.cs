using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int wordLength = word.Length;
            int letterValue = 0;

            for (int i = 0; i < wordLength; i++)
            {
                char letter = word[i];

                switch (letter)
                {
                    case 'a':
                        letterValue += 1;
                        break;
                    case 'e':
                        letterValue += 2;
                        break;
                    case 'i':
                        letterValue += 3;
                        break;
                    case 'o':
                        letterValue += 4;
                        break;
                    case 'u':
                        letterValue += 5;
                        break;
                }
            }

            Console.WriteLine(letterValue);
        }
    }
}
