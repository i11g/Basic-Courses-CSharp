using System;

namespace Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            string input=Console.ReadLine();
            string productName ="";
            int count = 0;
            int totalCount = 0;
            double productPrice;
            double productPrices = 0;

            while(input != "Stop")
            {
                productName = input;
                count++;
                totalCount++;
                productPrice= double.Parse(Console.ReadLine());
                if(count==3)
                {
                    budget-= productPrice / 2;
                    productPrices += productPrice / 2;
                    count = 0;
                }
                else
                {
                    budget-= productPrice;
                    productPrices += productPrice ;
                }
                if (budget<0)
                {
                    break;
                }
               input=Console.ReadLine();
            }
            if(input=="Stop")
            {
                Console.WriteLine($"You bought {totalCount} products for {productPrices:f2} leva.");
            }
            else if(budget<0) 
            {
                Console.WriteLine($"You don't have enough money!");
                Console.WriteLine($"You need {budget:f2} money!");
            }
        }
    }
}
