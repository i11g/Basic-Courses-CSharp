using System;

namespace Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            double litersGasoline=double.Parse(Console.ReadLine());
            string dayOfTheWeek=Console.ReadLine();

            double totalPrice = litersGasoline * 2.10 + 100;
            if(dayOfTheWeek=="Saturday")
            {
                totalPrice -= totalPrice * 0.1;
            }
            else
            {
                totalPrice-=totalPrice * 0.2; 
            }

            if(budget>totalPrice)
            {
                Console.WriteLine($"Safari time! Money left: {(budget - totalPrice):f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {(totalPrice - budget):f2} lv.");
            }

        }
    }
}
