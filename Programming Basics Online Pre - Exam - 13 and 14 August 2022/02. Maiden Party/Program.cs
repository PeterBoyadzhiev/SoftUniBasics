using System;

namespace _02._Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Любовно послание -0.60 лв.
            //•	Восъчна роза -7.20 лв.
            //•	Ключодържател - 3.60 лв.
            //•	Карикатура - 18.20 лв.
            //•	Късмет изненада -22 лв.


            double partyCost = double.Parse(Console.ReadLine());
            int loveLetterNumber = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keychains = int.Parse(Console.ReadLine());
            int picture = int.Parse(Console.ReadLine());
            int lucky = int.Parse(Console.ReadLine());

            int amounts = loveLetterNumber + roses + keychains + picture + lucky;

            double winnings = loveLetterNumber * 0.6 + roses * 7.2 + keychains * 3.6 + picture * 18.2 + lucky * 22;

            if (amounts >= 25)
            {
                winnings *= 0.65;
            }

            double winningsWithHosting = winnings * 0.9;

            if (winningsWithHosting >= partyCost)
            {
                Console.WriteLine($"Yes! {(winningsWithHosting - partyCost):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(partyCost - winningsWithHosting):f2} lv needed.");
            }

        }
    }
}
