using System;

namespace Film_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName=Console.ReadLine();
            string moviePacket=Console.ReadLine();
            int numberOfTickets=int.Parse(Console.ReadLine());
            double ticketPrices = 0;

            if(movieName== "John Wick")
            {
                if(moviePacket== "Drink")
                {
                    ticketPrices = numberOfTickets * 12;
                }
                else if (moviePacket == "Popcorn")
                {
                    ticketPrices= numberOfTickets * 15;
                }
                else
                {
                    ticketPrices = numberOfTickets*19;
                }
            }
            else if (movieName== "Star Wars")
            {
                if (moviePacket == "Drink")
                {
                    ticketPrices = numberOfTickets * 18;
                }
                else if (moviePacket == "Popcorn")
                {
                    ticketPrices = numberOfTickets * 25;
                }
                else
                {
                    ticketPrices = numberOfTickets * 30;
                }
                if (numberOfTickets>=4)
                {
                    ticketPrices -= ticketPrices * 0.3;
                }
            }
            else
            {
                if (moviePacket == "Drink")
                {
                    ticketPrices = numberOfTickets * 9;
                }
                else if (moviePacket == "Popcorn")
                {
                    ticketPrices = numberOfTickets * 11;
                }
                else
                {
                    ticketPrices = numberOfTickets * 14;
                }
                if (numberOfTickets ==2)
                {
                    ticketPrices -= ticketPrices * 0.15;
                }
            }
            Console.WriteLine($"Your bill is {ticketPrices:f2} leva.");
        }
    }
}
