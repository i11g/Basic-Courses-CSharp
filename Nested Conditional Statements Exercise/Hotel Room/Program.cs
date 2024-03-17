using System;

namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month=Console.ReadLine();
            int numberOfStays=int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;

            if (month=="May"||month=="October")
            {
                if (numberOfStays>14)
                {

                    priceStudio = numberOfStays*50-numberOfStays*50*0.3;
                    priceApartment = numberOfStays*65-numberOfStays*65*0.1;
                }
                else if (numberOfStays >7)
                {
                    priceStudio = numberOfStays * 50 - numberOfStays * 50 * 0.05;
                    priceApartment = numberOfStays * 65 - numberOfStays * 65 * 0.1;
                }
                else
                {
                    priceStudio = numberOfStays * 50;
                    priceApartment = numberOfStays * 65;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (numberOfStays > 14)
                {

                    priceStudio = numberOfStays * 75.20 - numberOfStays * 75.20 * 0.2;
                    priceApartment = numberOfStays * 68.70 - numberOfStays * 68.70 * 0.1;
                }
                else
                {
                    priceStudio = numberOfStays * 75.20;
                    priceApartment = numberOfStays * 68.70;
                }

            }
            else if (month == "July" || month == "August")
            {
                if (numberOfStays > 14)
                {

                    priceApartment = numberOfStays * 77 - numberOfStays * 77 * 0.1;
                    priceStudio = numberOfStays * 76;

                }
                else
                {
                    priceStudio = numberOfStays * 76;
                    priceApartment = numberOfStays * 77;
                }

            }
            Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
