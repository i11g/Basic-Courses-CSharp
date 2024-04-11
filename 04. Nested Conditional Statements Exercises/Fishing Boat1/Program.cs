using System;

namespace Fishing_Boat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                default:
                    price = 2600;
                    break;
            }
             if (numberOfFishermen <=6)
                    {
                        price -= price * 0.10;

                    }
              else if (numberOfFishermen <=11)
                    {
                        price -= price * 0.15;
                    }
              else
                    {
                        price -= price * 0.25;
                    }
                    
            
            if (numberOfFishermen % 2 == 0&&season !="Autumn")
            {
                price -=price * 0.05;
            }
            if (budget>=price)
            {

                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price-budget:f2} leva.");
            }
        }
    }
}
