using System;

namespace Easter_Lunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfEasterBread=int.Parse(Console.ReadLine());
            int numberOEggsd=int.Parse(Console.ReadLine());
            int kilogramsKurabii=int.Parse(Console.ReadLine());
            

            double priceEasterBread = numberOfEasterBread * 3.20;
            double priceEggs = numberOEggsd * 4.35;
            double priceKurabii = kilogramsKurabii * 5.40;
            double eggsPainting = numberOEggsd * 12*0.15;

            double total = priceEasterBread + priceEggs + priceKurabii + eggsPainting;

            Console.WriteLine($"{total:f2}");
        }
    }
}
