using System;

namespace Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            string destination=Console.ReadLine();
            string season=Console.ReadLine();
            int numberOfDays=int.Parse(Console.ReadLine());
            double projectesCost = 0;

            if(destination== "Dubai")
            {
                if(season== "Winter")
                {
                    projectesCost = 45000*numberOfDays;
                }
                else
                {
                    projectesCost = 40000*numberOfDays;

                }
                projectesCost -= projectesCost * 0.3;

            }
            else if(destination== "Sofia")
            {

                if (season == "Winter")
                {
                    projectesCost = 17000*numberOfDays;
                }
                else
                {
                    projectesCost = 12500 * numberOfDays;

                }
                projectesCost +=projectesCost *0.25;

            }
            else
            {
                if (season == "Winter")
                {
                    projectesCost = 24000*numberOfDays ;
                }
                else
                {
                    projectesCost = 20250*numberOfDays ;

                }

            }
            if (budget>projectesCost) {
                Console.WriteLine($"The budget for the movie is enough! We have {(budget - projectesCost):f2} leva left!"); 
            }
            else
            {
                Console.WriteLine($"The director needs {(projectesCost - budget):f2} leva more!");
            }

        }
    }
}
