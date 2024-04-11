using System;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string name=Console.ReadLine();
            double points=double.Parse(Console.ReadLine());

            int numberOfGraders=int.Parse(Console.ReadLine());
            string nameGrager;
            double pointsGrader;
            double totalPoints = points;

            for (int i = 1; i <=numberOfGraders; i++)
            {
                nameGrager=Console.ReadLine(); 
                pointsGrader=double.Parse(Console.ReadLine());
                totalPoints +=(nameGrager.Length * pointsGrader) / 2;

                if(totalPoints > 1250.5)
                {
                    break;
                }
            }
            if (totalPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {totalPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {(1250.5 - totalPoints):f1} more!");
            }
                
            
        }
    }
}
