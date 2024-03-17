using System;

namespace Easter_Bake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBreads=int.Parse(Console.ReadLine());
            int quantitySugar;
            int quantityDougth;
            int totalSugar = 0;
            int totalDough = 0;
            int maxquantitySugar = int.MinValue;
            int maxquantiytDough=int.MinValue;

            for (int i = 0; i <numberOfBreads ; i++)
            {
                quantitySugar = int.Parse(Console.ReadLine());
                quantityDougth = int.Parse(Console.ReadLine());
                
                totalSugar += quantitySugar;
                totalDough += quantityDougth;
                if(quantityDougth>maxquantiytDough) 
                {
                    maxquantiytDough = quantityDougth;
                }
                if(quantitySugar>maxquantitySugar)
                {
                    maxquantitySugar= quantitySugar;
                }

            }
            Console.WriteLine($"Sugar: {Math.Ceiling((double)totalSugar / 950)}");
            Console.WriteLine($"Flour: {Math.Ceiling((double)totalDough / 750)}");
            Console.WriteLine($"Max used flour is {maxquantiytDough} grams, max used sugar is {maxquantitySugar} grams.");
        }
    }
}
