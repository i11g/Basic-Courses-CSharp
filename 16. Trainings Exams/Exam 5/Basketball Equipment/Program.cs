using System;

namespace Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taxs=int.Parse(Console.ReadLine());

            double sneakers = taxs * 0.6;
            double outfit = sneakers * 0.8;
            double ball = outfit * 1.00 / 4.00;
            double accesories = ball * 1.00 / 5.00;

            double total = taxs + accesories + ball + outfit + sneakers;
            Console.WriteLine($"{total:f2}");

        }
    }
}
