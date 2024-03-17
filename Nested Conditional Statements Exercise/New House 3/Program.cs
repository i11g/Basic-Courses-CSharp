using System;

namespace New_House_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers=Console.ReadLine();
            int numberOfFlowers=int.Parse(Console.ReadLine());
            int budget=int.Parse(Console.ReadLine());
            double price = 0;

            if(flowers=="Roses")
            {
                price = numberOfFlowers * 5;
                if(numberOfFlowers>80)
                {
                    price *= 0.9;
                }
            }
            else if (flowers == "Dahlias")
            {
                price = numberOfFlowers * 3.8;
                if (numberOfFlowers > 90)
                {
                    price *= 0.85;
                }
            }
            else if (flowers == "Gladiolus")
            {
                price = numberOfFlowers * 2.5;
                if (numberOfFlowers < 80)
                {
                    price *= 1.20;
                }
            }
            else if (flowers == "Tulips")
            {
                price = numberOfFlowers * 2.8;
                if (numberOfFlowers > 80)
                {
                    price *= 0.85;
                }
            }
            else if (flowers == "Narcissus")
            {
                price = numberOfFlowers * 3;
                if (numberOfFlowers <120)
                {
                    price *= 1.15;
                }
            }
            if (budget>=price)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {budget - price:f2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }

        }
    }
}
