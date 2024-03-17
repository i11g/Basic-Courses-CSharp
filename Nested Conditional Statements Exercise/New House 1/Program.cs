using System;

namespace New_House_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0.0;


            switch (flowers)
            {
                case "Roses":
                    price = numberOfFlowers * 5;
                    if (numberOfFlowers > 80)
                    {
                        price -= price * 0.1;
                    }
                    break;
                case "Dahlias":
                    price = numberOfFlowers * 3.80;
                    if (numberOfFlowers > 90)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Tulips":
                    price = numberOfFlowers * 2.80;
                    if (numberOfFlowers > 80)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Narcissus":
                    price = numberOfFlowers * 3;
                    if (numberOfFlowers < 120)
                    {
                        price += price * 0.15;
                    }
                    break;
                case "Gladiolus":
                    price = numberOfFlowers * 2.5;
                    if (numberOfFlowers < 80)
                    {
                        price += price * 0.20;
                    }
                    break;
            }
            if (budget > price)
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
