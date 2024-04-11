using System;

namespace Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegetarian = int.Parse(Console.ReadLine());

            double sum = chicken * 10.35 + fish * 12.40 + vegetarian * 8.15;
            double totalSum = sum + sum * 0.2;
            double totalDelivery = totalSum + 2.50;
            Console.WriteLine(totalDelivery);
        }
    }
}
