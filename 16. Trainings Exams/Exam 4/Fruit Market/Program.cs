using System;

namespace Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceStrauberries=double.Parse(Console.ReadLine());
            double kilogramsBananas=double.Parse(Console.ReadLine());
            double kilogramsOranges=double.Parse(Console.ReadLine());
            double kilogramsRasberies=double.Parse(Console.ReadLine());
            double kilogramsStrauberies=double.Parse(Console.ReadLine());

            double totalPrice = priceStrauberries * kilogramsStrauberies + priceStrauberries * 0.5 * kilogramsRasberies + priceStrauberries * 0.5 * 0.2 * kilogramsBananas + priceStrauberries * 0.5 * 0.6 * kilogramsOranges;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
