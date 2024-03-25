using System;

namespace Energy_Booster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit=Console.ReadLine();
            string size=Console.ReadLine();
            int quantity=int.Parse(Console.ReadLine());
            double price = 0;

            if(fruit== "Watermelon")
            {
                if (size=="small")
                {
                    price = (2 * 56)*quantity;
                }
                else
                {
                    price=(5*28.70)*quantity;
                }
            }
            else if (fruit== "Mango")
            {
                if (size == "small")
                {
                    price = 2 * 36.66*quantity;
                }
                else
                {
                    price = 5 * 19.60*quantity;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    price = 2 * 42.10*quantity;
                }
                else
                {
                    price = 5 * 24.80*quantity;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    price = 2 * 20*quantity;
                }
                else
                {
                    price = 5 * 15.20*quantity;
                }
            }
            if (price>400&&price<=1000)
            {
                price -= price * 0.15;
            }
            else if(price>1000)
            {
                price -= price * 0.50;
            }
            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
