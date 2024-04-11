using System;

namespace Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string input = Console.ReadLine();
            string field = "";
            int points = 0;
            int remainingPoints = 301;
            int numberOfshots = 0;
            int lostShots = 0;

            while (input != "Retire")
            {
                field = input;
                points = int.Parse(Console.ReadLine());

                if (field == "Single")
                {
                    remainingPoints -= points;
                    if (remainingPoints < 0)
                    {
                        lostShots++;
                        remainingPoints += points;
                        numberOfshots--;

                    }
                    numberOfshots++;
                }
                else if (field == "Double")
                {
                    remainingPoints -= points * 2;
                    if (remainingPoints < 0)
                    {
                        lostShots++;
                        remainingPoints += points*2;
                        numberOfshots--;
                    }
                    numberOfshots++;
                }
                else if (field == "Triple")
                {
                    remainingPoints -= points * 3;
                    if (remainingPoints < 0)
                    {
                        lostShots++;
                        remainingPoints += points*3;
                        numberOfshots--;
                    }
                    numberOfshots++;
                }
                if (remainingPoints == 0)
                {
                    break;
                }
                input=Console.ReadLine();
            }
            if (remainingPoints == 0)
            {
                Console.WriteLine($"{name} won the leg with {numberOfshots} shots.");
            }
            else if (input == "Retire")
            {
                Console.WriteLine($"{name} retired after {lostShots} unsuccessful shots.");
            }
        }
    }
}
