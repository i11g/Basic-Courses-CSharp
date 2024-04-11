using System;
using System.ComponentModel.Design;

namespace Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string movieName;
            int studentTickets = 0;
            int standartTickets = 0;
            int kidsTickets = 0;
            int totaltickts = 0;

            while (input != "Finish")
            {
                movieName = input;
                int freeSeats = int.Parse(Console.ReadLine());
                string command = Console.ReadLine();
                string type;
                int tickets = 0;
                bool isFull = false;
                while (command != "End")
                {
                    type = command;
                                        
                    
                    if (type == "student")
                    {
                        studentTickets++;

                    }
                    else if (type == "standard")
                    {
                        standartTickets++;
                    }
                    else
                    {
                        kidsTickets++;

                    }
                    tickets++;
                    if(tickets==freeSeats)
                    {
                        isFull = true;
                        break;
                    }
                    command = Console.ReadLine();
                }

                if (command == "End"||isFull)
                {
                    Console.WriteLine($"{movieName} - {(double)tickets / freeSeats * 100:f2}% full.");
                }
               
                input = Console.ReadLine();

            }
            if (input == "Finish")
            {
                totaltickts = standartTickets + studentTickets + kidsTickets;

                Console.WriteLine($"Total tickets: {totaltickts}");
                Console.WriteLine($"{(double)studentTickets / totaltickts * 100:f2}% student tickets.");
                Console.WriteLine($"{(double)standartTickets / totaltickts * 100:f2}% standard tickets.");
                Console.WriteLine($"{(double)kidsTickets / totaltickts * 100:f2}% kids tickets.");
            }

        }
    }
}
