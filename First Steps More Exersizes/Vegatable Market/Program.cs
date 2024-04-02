using System;

namespace Vegatable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables=double.Parse(Console.ReadLine()); 
            double priceFruits=double.Parse(Console.ReadLine()); 
            double kilogramsVegetables=double.Parse(Console.ReadLine()); 
            double kilogramsFruits=double.Parse(Console.ReadLine());

            double sum = (priceVegetables * kilogramsVegetables / 1.94) + (priceFruits * kilogramsFruits/1.94);
            Console.WriteLine($"{sum:F2}");
        }
    }
}
