using System;

namespace Basketball_Tournaments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            int totalGames = 0;
            int wins = 0;
            int lost = 0;

            while (input != "End of tournaments") 
            {
                string tournamentName=input;
                int numberOfGames=int.Parse(Console.ReadLine());
                totalGames += numberOfGames;

                for (int i = 1; i <=numberOfGames; i++)
                {
                    int pointsDesi=int.Parse(Console.ReadLine());
                    int pointsOthers=int.Parse(Console.ReadLine());
                    if(pointsDesi > pointsOthers)
                    {
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {pointsDesi-pointsOthers}");
                        wins++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {pointsOthers-pointsDesi}");
                        lost++;
                    }

                }
                input=Console.ReadLine();
            }
            Console.WriteLine($"{(double) wins/ totalGames*100}%");
            Console.WriteLine($"{(double)lost / totalGames*100}%");
        }
    }
}
