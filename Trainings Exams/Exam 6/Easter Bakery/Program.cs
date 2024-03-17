using System;

namespace Easter_Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double doughPrice=double.Parse(Console.ReadLine()); 
            double doughKilograms=double.Parse(Console.ReadLine()); 
            double sugarKilograms=double.Parse(Console.ReadLine()); 
            int numberOfEggs=int.Parse(Console.ReadLine());
            int packetsOfMaya=int.Parse(Console.ReadLine());

            double pricesugar=sugarKilograms*doughPrice*0.75;
            double priceEggs=numberOfEggs*doughPrice*1.10;
            double priceMaya = packetsOfMaya * (doughPrice*0.75) * 0.2;

            double total = doughPrice * doughKilograms + priceEggs + priceMaya + pricesugar;

            Console.WriteLine($"{total:f2}");
        }
    }
}
