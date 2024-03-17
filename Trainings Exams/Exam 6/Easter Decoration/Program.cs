using System;

namespace Easter_Decoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfClients=int.Parse(Console.ReadLine());
            string input="";
            string purchase;
            double totalPrice = 0;
            double totaltotalPrice = 0;
            for (int i = 1; i <=numberOfClients; i++)
            {   
                input= Console.ReadLine();
                int numberOfPurchases = 0;
                while (input != "Finish")
                {
                    purchase = input;
                    numberOfPurchases++;    
                    if (purchase == "basket")
                    {
                        totalPrice += 1.50;
                    }
                    else if (purchase == "wreath")
                    {
                        totalPrice += 3.80;
                    }
                    else
                    {
                        totalPrice += 7.00;
                    }
                                       
                    input = Console.ReadLine();
                }
                if(input=="Finish")
                {
                    if (numberOfPurchases % 2 == 0)
                    {
                        totalPrice -= totalPrice * 0.2;
                    }
                    Console.WriteLine($"You purchased {numberOfPurchases} items for {totalPrice:f2} leva.");
                    totaltotalPrice += totalPrice;
                    totalPrice = 0;
                }
            }
            Console.WriteLine($"Average bill per client is: {totaltotalPrice / numberOfClients:f2} leva.");

        }
    }
}
