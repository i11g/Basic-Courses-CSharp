using System;

namespace Birthday_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rentPrice=double.Parse(Console.ReadLine());

            double priceCake = rentPrice * 0.20;
            double priceBevaradges = priceCake * 0.55;
            double priceAnimator = rentPrice * 1.00 / 3.00;
            double totalPrice = priceCake + priceBevaradges + priceAnimator + rentPrice;
            Console.WriteLine(totalPrice);

        }
    }
}
