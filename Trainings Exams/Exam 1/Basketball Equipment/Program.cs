using System;

namespace Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax=int.Parse(Console.ReadLine());
            double priceKets = tax-tax * 0.4;
            double priceEkip = priceKets-priceKets * 0.2;
            double priceBall = priceEkip * 1.0 / 4.0;
            double priceAcsesories = priceBall * 1.0 / 5.0;

            double totalprice = priceKets + priceEkip + priceBall + priceAcsesories + tax;
            Console.WriteLine($"{totalprice:f2}");

        }
    }
}
