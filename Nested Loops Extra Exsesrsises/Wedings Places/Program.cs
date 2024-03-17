using System;

namespace Wedings_Places
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int numberOfRowsFirstSector = int.Parse(Console.ReadLine());
            int numberOfSeatsOddRow = int.Parse(Console.ReadLine());
            int totalSeats = 0;

            for (char sectors = 'A'; sectors <= lastSector; sectors++)
            {
                for (int rows = 1; rows <= numberOfRowsFirstSector; rows++)
                {
                    int seatsInRow = 0;
                    if (rows % 2 == 0)
                    {
                        seatsInRow = numberOfSeatsOddRow + 2;
                    }
                    else
                    {
                        seatsInRow = numberOfSeatsOddRow;
                    }
                    totalSeats+=seatsInRow;
                    for (char seats = 'a'; seats <='a'+seatsInRow ; seats++)
                    {

                        Console.WriteLine($"{sectors}{rows}{seats}");

                    }
                }
                numberOfRowsFirstSector++;
            }
            Console.WriteLine($"{totalSeats}");
        }
    }
}
