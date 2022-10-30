using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            double priceWithoutDiscount = size * 7.61;
            double Discount = priceWithoutDiscount * 0.18;
            Console.WriteLine($"The final price is: {priceWithoutDiscount - Discount}");
            Console.WriteLine($"The discount is: {Discount}");
        }
    }
}
