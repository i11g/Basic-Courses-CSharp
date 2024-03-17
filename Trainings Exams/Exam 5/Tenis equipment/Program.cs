using System;

namespace Tenis_equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceRaketa=double.Parse(Console.ReadLine());
            int numberRaketi=int.Parse(Console.ReadLine());
            int numberSneakers=int.Parse(Console.ReadLine());

            double total = priceRaketa * numberRaketi + priceRaketa * 1.00 / 6.00 * numberSneakers;
            double final = total + total * 0.2;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(final * 1.00 / 8.00)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(final * 7.00 / 8.00)}");
        }
    }
}
