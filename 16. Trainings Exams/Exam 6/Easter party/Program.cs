using System;

namespace Easter_party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuests=int.Parse(Console.ReadLine());
            double price=double.Parse(Console.ReadLine());
            double budget=double.Parse(Console.ReadLine());
            double priceTotal =budget*0.1;

               if(numberOfGuests<10)
            {
                priceTotal+= price*numberOfGuests;
            }
            else if(numberOfGuests<=15)
            {
                priceTotal+=price*0.85*numberOfGuests;
            }
            else if (numberOfGuests<=20)
            {
                priceTotal+= price * 0.80 * numberOfGuests;
            }
            else
            {
                priceTotal+= price * 0.75 * numberOfGuests;
            }
            if(budget>priceTotal)
            {
                Console.WriteLine($"It is party time! {budget - priceTotal:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {priceTotal-budget:f2} leva needed.");
            }


        }
    }
}
