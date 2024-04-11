using System;

namespace Tenis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournamts=int.Parse(Console.ReadLine());
            int startingPoints=int.Parse(Console.ReadLine()) ;
            double finalPoints = 0;
            double averagePoints = 0;
            int numberOfwonTournaments = 0;

            for (int i = 1; i <=numberOfTournamts; i++)
            {
                string etap=Console.ReadLine();

                if(etap =="W")
                {
                    finalPoints += 2000;
                    numberOfwonTournaments++;
                }
                else if(etap =="F")
                {
                    finalPoints += 1200;
                }
                else if(etap =="SF")
                {
                    finalPoints += 720;
                }
                
                
            }
            Console.WriteLine($"Final Points: {finalPoints+=startingPoints}");
            Console.WriteLine($"{Math.Floor((finalPoints-startingPoints)/numberOfTournamts)}");
            Console.WriteLine($"{(double)numberOfwonTournaments/numberOfTournamts*100:f2}%");
        }
    }
}
