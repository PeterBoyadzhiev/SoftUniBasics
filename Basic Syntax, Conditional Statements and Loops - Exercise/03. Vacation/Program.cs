using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pricePerPerson = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.8;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46;
                            break;
                    }
                    break;

                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 10.9;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.6;
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                            break;
                    }
                    break;

                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.5;
                            break;
                    }
                    break;
            }

            double totalPrice = count * pricePerPerson;

            if (count >= 30 && typeOfGroup == "Students")
            {
                totalPrice *= 0.85;
            }
            if (count >= 100 && typeOfGroup == "Business")
            {
                totalPrice = (count - 10) * pricePerPerson;
            }
            if (count >= 10 && count <= 20 && typeOfGroup == "Regular")
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
