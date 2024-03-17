using System;

namespace Tenis_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceTenisRaquatte=double.Parse(Console.ReadLine());
            int numberTenisRaquatte=int.Parse(Console.ReadLine());
            int numberMaratonki=int.Parse(Console.ReadLine());

            double priceRaquette = priceTenisRaquatte * numberTenisRaquatte;
            double priceMaratonki = numberMaratonki * (priceTenisRaquatte * (double)(1.0 / 6.0));
            double priceTotal = (priceRaquette + priceMaratonki)*0.2+priceRaquette+priceMaratonki;
            Console.WriteLine($"Price to be paid by Djokovic {Math.Round(priceTotal * (double)(1.0 / 8.0))}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceTotal * (double)(7.0 / 8.0))}");
        }
    }
}
