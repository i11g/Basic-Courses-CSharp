using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int numberRows = int.Parse(Console.ReadLine());
            int numberCollums = int.Parse(Console.ReadLine());
            double income = 0;

            if (type == "Premiere")
            {
                income = numberCollums * numberRows * 12;
            }
            else if (type == "Normal")
            {
                income = numberCollums * numberRows * 7.50;
            }
            if (type == "Discount")
            {
                income = numberCollums * numberRows * 5.00;
            }

            Console.WriteLine($"{income:f2} leva");
                }
    }
}
