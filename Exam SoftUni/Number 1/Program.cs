using System;

namespace Number_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfPaper=int.Parse(Console.ReadLine());
            int numbersOfSheets=int.Parse(Console.ReadLine());
            double litersOfGlue=double.Parse(Console.ReadLine());
            double discount=double.Parse(Console.ReadLine());

            double priceOfPaper = numbersOfPaper * 5.80;
            double priceOfSheet = numbersOfSheets * 7.20;
            double priceOfGlue = litersOfGlue * 1.20;
            double totalPrice = priceOfPaper + priceOfSheet + priceOfGlue;
            discount= totalPrice * discount/100;
            totalPrice -= discount;
            Console.WriteLine($"{totalPrice:f3}");
        }
    }
}
