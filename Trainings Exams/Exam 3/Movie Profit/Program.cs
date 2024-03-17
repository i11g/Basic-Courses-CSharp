using System;

namespace Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName=Console.ReadLine();
            int numberOfDays=int.Parse(Console.ReadLine());
            int numberOfTickets=int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            double percentileForCinema = double.Parse(Console.ReadLine());

            double income = numberOfDays * numberOfTickets * ticketPrice;
            income -= income * percentileForCinema/100;
            Console.WriteLine($"The profit from the movie {movieName} is {income:f2} lv.");




                }
    }
}
