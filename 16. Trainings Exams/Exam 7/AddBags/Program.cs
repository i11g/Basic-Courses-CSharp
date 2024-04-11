using System;

namespace AddBags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfLuggageMoreTwentyKilograms=double.Parse(Console.ReadLine());
            double kilogramsOfLuggage=double.Parse(Console.ReadLine());
            int daysUntilTravel=int.Parse(Console.ReadLine());
            int numberOfLuggages = int.Parse(Console.ReadLine());
            double price = 0;

            if(kilogramsOfLuggage<10)
            {
                price = priceOfLuggageMoreTwentyKilograms * 0.2;
            }
            else if(kilogramsOfLuggage <=20)
            {
                price = priceOfLuggageMoreTwentyKilograms * 0.5;
            }
            else
            {
                price = priceOfLuggageMoreTwentyKilograms;
            }
            if (daysUntilTravel>30)
            {
                price += price * 0.1;
            }
            else if(daysUntilTravel<30&&daysUntilTravel>7)
            {
                price += price * 0.15;
            }
            else
            {
                price += price * 0.4;
            }
            Console.WriteLine($"The total price of bags is: {price*numberOfLuggages:f2} lv. ");
        }

    }
}
