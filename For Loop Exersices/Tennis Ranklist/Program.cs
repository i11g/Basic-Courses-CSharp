using System;

namespace Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTurnaments=int.Parse(Console.ReadLine());
            int startingPoints=int.Parse(Console.ReadLine());
            int finalPoints = startingPoints;
            int averagePoints = 0;
            int winsTournament = 0;
            int numberOfTournamnets = 0;

            for (int i = 1; i <=numberOfTurnaments; i++)
            {
                string tournamentStage=Console.ReadLine();

                if(tournamentStage=="F")
                {
                    finalPoints+=1200;
                }
                else if(tournamentStage=="W")
                {
                    finalPoints+=2000;
                    winsTournament++;
                }
                else if (tournamentStage=="SF")
                {
                    finalPoints+= 720;
                }
                numberOfTournamnets++;
            }
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {Math.Floor((double)(finalPoints-startingPoints)/numberOfTournamnets)}");
            Console.WriteLine($"{(double)winsTournament/numberOfTournamnets*100:f2}%");
        }
    }
}
