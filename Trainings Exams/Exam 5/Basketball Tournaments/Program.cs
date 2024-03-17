using System;

namespace Basketball_Tournaments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string nameOftournaments;
            int numberOfGames = 0;
            int wonGames = 0;
            int lostGames = 0;
            int totalGames = 0;

            while (input != "End of tournaments")
            {
                nameOftournaments = input; 
                numberOfGames=int.Parse(Console.ReadLine());
                int pointsDesi = 0;
                int pointsOthers = 0;
                int numberOfGamesD = 0;
                
              for (int i = 1; i<=numberOfGames; i++)
                {
                    totalGames++;
                    pointsDesi = int.Parse(Console.ReadLine());
                    pointsOthers = int.Parse(Console.ReadLine());
                    if (pointsDesi>pointsOthers)
                    {
                        Console.WriteLine($"Game {i} of tournament {nameOftournaments}: win with {pointsDesi-pointsOthers} points.");
                        wonGames++;
                    }
                    else if(pointsDesi<pointsOthers)
                    {
                        Console.WriteLine($"Game {i} of tournament {nameOftournaments}: lost with {pointsOthers-pointsDesi} points.");
                        lostGames++;
                    }
                }
                input=Console.ReadLine();

            }
            if(input== "End of tournaments")
            {
                Console.WriteLine($"{(double) wonGames/totalGames*100:f2}% matches win");
                Console.WriteLine($"{(double) lostGames/totalGames*100:f2}% matches lost");
            }
        }
    }
}
