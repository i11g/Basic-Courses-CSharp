using System;

namespace Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageLily=int.Parse(Console.ReadLine());
            double price=double.Parse(Console.ReadLine());
            int priceOfToy=int.Parse(Console.ReadLine());
            double sumCollected = 0;

            for  (int years = 1; years <=ageLily; years++) 
            { 
                if (years%2==0) 
                { 
                    sumCollected += (5*years);
                    sumCollected -= 1;
                }
                else
                {
                    sumCollected += priceOfToy;
                }
            }
            if (sumCollected>=price)
            {
                Console.WriteLine($"Yes! {sumCollected - price:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(sumCollected - price):f2}");
            }
        }
    }
}
