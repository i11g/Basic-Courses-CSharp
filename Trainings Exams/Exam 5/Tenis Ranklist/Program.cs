using System;

namespace Tenis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfTournaments=int.Parse(Console.ReadLine());
           int startingPoints=int.Parse(Console.ReadLine());
            string stage;
            int finalPoints = startingPoints;
            int wonTournaments = 0;

            for (int i = 1; i <= numberOfTournaments; i++)
            {
                stage= Console.ReadLine();
                if (stage =="F")
                {
                    finalPoints += 1200;
                }
                else if(stage =="SF") 
                {
                    finalPoints += 720;
                }
                else if( stage =="W")
                {
                    finalPoints += 2000;
                    wonTournaments++;
                }
            }
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {(finalPoints-startingPoints)/numberOfTournaments}");
            Console.WriteLine($"{(double)wonTournaments/numberOfTournaments*100:f2}%");
        }
    }
}
