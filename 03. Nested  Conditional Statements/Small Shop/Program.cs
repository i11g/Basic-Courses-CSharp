using System;

namespace Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product=Console.ReadLine();
            string city=Console.ReadLine();
            double quantity=double.Parse(Console.ReadLine());
            double price = 0;


            switch (product)
            {
                case "coffee":
                    if(city =="Sofia")
                    {
                        price = 0.50*quantity;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 0.40*quantity;
                    }
                    else if (city == "Varna")
                    {
                        price = 0.45 * quantity;
                    }
                    break;
                case "water":
                    if (city == "Sofia")
                    {
                        price = 0.80 * quantity;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 0.70 * quantity;
                    }
                    
                    else if (city == "Varna")
                    {
                        price = 0.70 * quantity;
                    }
                    break;
                case "beer":
                    if (city == "Sofia")
                    {
                        price = 1.20 * quantity;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 1.15 * quantity;
                    }
                        
                    else if (city == "Varna")
                    {
                        price = 1.10 * quantity;
                    }
                    break;
                case "sweets":
                    if (city == "Sofia")
                    {
                        price = 1.45 * quantity;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = 1.30 * quantity;
                    }
                        
                    if (city == "Varna")
                    {
                        price = 1.35 * quantity;
                    }
                    break;
                case "peanuts":
                    if (city == "Sofia")
                    {
                        price = 1.60 * quantity;
                    }
                    else  if (city == "Plovdiv")
                    {
                        price = 1.50 * quantity;
                    }
                        
                    if (city == "Varna")
                    {
                        price = 1.55 * quantity;
                    }
                    break;
            }
            Console.WriteLine(price);
        }
    }
}
