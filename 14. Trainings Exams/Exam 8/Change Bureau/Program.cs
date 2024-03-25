using System;

namespace Change_Bureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberofBitcoin=int.Parse(Console.ReadLine());
            double numberOfjuans=double.Parse(Console.ReadLine());
            double commission=double.Parse(Console.ReadLine());

            double totalLeva = (numberofBitcoin * 1168 + numberOfjuans * 0.15 * 1.76) / 1.95;
            totalLeva -= totalLeva * commission / 100;
            Console.WriteLine($"{totalLeva:f2}");
        }
    }
}
