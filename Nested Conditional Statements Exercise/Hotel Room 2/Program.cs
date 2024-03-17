using System;

namespace Hotel_Room_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season=Console.ReadLine();
            int numberOfNigths=int.Parse(Console.ReadLine());
            double priceA = 0;
            double priceS = 0;


           if (numberOfNigths > 14)
            {
                if (season == "May" || season == "October")
                {
                    priceS = numberOfNigths * 50;
                    priceS -= (numberOfNigths * 50) * 0.30;
                    priceA = numberOfNigths * 65;
                    priceA -= (numberOfNigths * 65) * 0.10;
                }
                else if (season == "June" || season == "September")
                {
                    priceS = numberOfNigths * 75.20;
                    priceS -= (numberOfNigths * 75.20) * 0.20;
                    priceA = numberOfNigths * 68.70;
                    priceA -= (numberOfNigths * 68.70) * 0.10;
                }
                else
                {
                    priceS = numberOfNigths * 76;
                    priceA = numberOfNigths * 77;
                    priceA -= (numberOfNigths * 77) * 0.10;
                }
            }
            else if (numberOfNigths > 7)
            {
                if (season == "May" || season == "October")
                {
                    priceS = numberOfNigths * 50;
                    priceS -= (numberOfNigths * 50) * 0.05;
                    priceA = numberOfNigths * 65;

                }
                else if (season == "June" || season == "September")
                {
                    priceS = numberOfNigths * 75.20;
                    priceA = numberOfNigths * 68.70;

                }
                else
                {
                    priceS = numberOfNigths * 76;
                    priceA = numberOfNigths * 77;

                }
            }
           else
            {
                if (season == "May" || season == "October")
                {
                    priceS = numberOfNigths * 50;
                    priceA = numberOfNigths * 65;

                }
                else if (season == "June" || season == "September")
                {
                    priceS = numberOfNigths * 75.20;
                    priceA = numberOfNigths * 68.70;

                }
                else
                {
                    priceS = numberOfNigths * 76;
                    priceA = numberOfNigths * 77;

                }
            }

            Console.WriteLine($"Apartment: {priceA:f2} lv.");
            Console.WriteLine($"Studio: {priceS:f2} lv.");
        }
    }
}
