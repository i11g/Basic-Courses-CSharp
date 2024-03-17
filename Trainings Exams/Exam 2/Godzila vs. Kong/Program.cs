using System;

namespace Godzila_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            int numberOfStatist=int.Parse(Console.ReadLine());
            double priceClothing=double.Parse(Console.ReadLine());

            double price = numberOfStatist * priceClothing; 

            if (numberOfStatist > 150)
            {
                price -= price * 0.1;
            }
            
            double totalPrice = price + budget * 0.10;
            if(totalPrice<=budget)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget-totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice-budget:f2} leva left.");
            }
            

        }
    }
}
