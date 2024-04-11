using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int naylon=int.Parse(Console.ReadLine());
            int paint=int.Parse(Console.ReadLine());
            int thinner=int.Parse(Console.ReadLine());
            int hours=int.Parse(Console.ReadLine());

            double pricePainting = naylon * 1.50 + paint * 14.50 + thinner * 5.00;
            double totalPainting = pricePainting + (paint * 0.1 * 14.50) + (2 * 1.50) + 0.40;
            double painters = totalPainting * 0.3 * hours;
            double totalSum = totalPainting + painters;

            Console.WriteLine($"{totalSum}");
        }
    }
}
