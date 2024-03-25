using System;

namespace Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            int numberOfTicktsAdults=int.Parse(Console.ReadLine());
            int numberOfTicktsKids=int.Parse(Console.ReadLine());
            double priceAdult=double.Parse(Console.ReadLine());
            double priceTaxes=double.Parse(Console.ReadLine());

            double totalAdults = numberOfTicktsAdults * (priceAdult + priceTaxes);
            double totalKids= numberOfTicktsKids*(priceAdult*0.3+priceTaxes);
            double profit = (totalAdults+totalKids) * 0.2;

            Console.WriteLine($"The profit of your agency from {name} tickets is {profit:f2} lv.");
        }
    }
}
