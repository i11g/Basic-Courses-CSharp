using System;

namespace Easter_guests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuests=int.Parse(Console.ReadLine());
            int budget=int.Parse(Console.ReadLine());

            double numberOfEasterBreads = Math.Ceiling(numberOfGuests / 3.00);
            int numberOfEggs = numberOfGuests * 2;
            double priceEasterBread = numberOfEasterBreads * 4;
            double priceEggs = numberOfEggs * 0.45;
            double total=priceEasterBread + priceEggs;
            
            if (budget > total)
            {
                Console.WriteLine($"Lyubo bought {numberOfEasterBreads} Easter bread and {numberOfEggs} eggs.");
                Console.WriteLine($"He has {(budget - total):f2} lv. left.");
            }
            else 
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {(total-budget):f2} lv. more.");
            }
        }
    }
}
