using System;

namespace World_Snooker_Championship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stage=Console.ReadLine();
            string ticketType=Console.ReadLine();
            int numberOfTickts=int.Parse(Console.ReadLine());
            string picture=Console.ReadLine();
            double price = 0;

            if (stage=="Quater final")
            {
                if (ticketType=="Standart")
                {
                    price = numberOfTickts * 55.50;
                }
                else if(ticketType=="Premium")
                {
                    price = numberOfTickts * 105.20;
                }
                else if(ticketType=="VIP")
                {
                    price = numberOfTickts * 118.90;
                }
            }
            else if (stage == "Semi final")
            {
                if (ticketType == "Standart")
                {
                    price = numberOfTickts * 75.88;
                }
                else if (ticketType == "Premium")
                {
                    price = numberOfTickts * 125.22;
                }
                else if (ticketType == "VIP")
                {
                    price = numberOfTickts * 300.40;
                }
            }
            else if (stage == "Final")
            {
                if (ticketType == "Standart")
                {
                    price = numberOfTickts * 110.10;
                }
                else if (ticketType == "Premium")
                {
                    price = numberOfTickts * 160.66;
                }
                else if (ticketType == "VIP")
                {
                    price = numberOfTickts * 400;
                }
            }
            if (price>4000)
            {
                price -= price * 0.25;
            }
            else if(price>2500)
            {
                price -= price * 0.10;
            }
            if (picture=="Y"&&price<=4000)
            {
                price +=numberOfTickts * 40;

            }
            Console.WriteLine($"{price:f2}");

        }
    }
}
