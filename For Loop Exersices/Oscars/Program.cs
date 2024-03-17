using System;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            double pointsFromAcademy=double.Parse(Console.ReadLine());
            int numberOfAppraisers=int.Parse(Console.ReadLine());

            string nameAppraiser=string.Empty;
            double points = 0;
            double totalPoints = pointsFromAcademy;

            for (int i = 0; i < numberOfAppraisers; i++)
            {
                nameAppraiser = Console.ReadLine();
                int name1 = nameAppraiser.Length;
                points=double.Parse(Console.ReadLine());

                 totalPoints+=(points*name1/2);

                if(totalPoints>=1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {totalPoints:f1}!");
                    break;
                }
                 
            }
            
            if (totalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - totalPoints:f1} more!");
            }

        }
    }
}
