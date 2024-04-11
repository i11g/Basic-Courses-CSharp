using System;

namespace Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceMaskerel=double.Parse(Console.ReadLine());
            double priceSprinkle=double.Parse(Console.ReadLine());
            double kiklogramP=double.Parse(Console.ReadLine());
            double kiklogramS=double.Parse(Console.ReadLine());
            double kiklogramM=double.Parse(Console.ReadLine());

            double sum = (priceMaskerel * 1.60 * kiklogramP) + (priceSprinkle * 1.80 * kiklogramS) + kiklogramM * 7.50;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
