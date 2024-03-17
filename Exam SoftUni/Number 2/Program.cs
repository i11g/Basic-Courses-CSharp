using System;

namespace Number_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfTShirt=double.Parse(Console.ReadLine());
            double sumNeeded=double.Parse(Console.ReadLine());

            double priceOfshorts = priceOfTShirt * 0.75;
            double priceOfsoks = priceOfshorts * 0.20;
            double priceOfshoes = (priceOfTShirt+priceOfshorts)*2;
            double totalPrice = priceOfTShirt + priceOfshorts + priceOfsoks + priceOfshoes;
            totalPrice -= totalPrice * 0.15;
            if(totalPrice>=sumNeeded)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine($"No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(sumNeeded-totalPrice):f2} lv. more.");
            }
        }
    }
}
