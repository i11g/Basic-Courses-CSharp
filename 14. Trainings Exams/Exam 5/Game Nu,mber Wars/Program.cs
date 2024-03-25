using System;

namespace Game_Nu_mber_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameFirstPlaye=Console.ReadLine();
            string nameSecondPlaye=Console.ReadLine(); 
            string input=Console.ReadLine();
            int cardFirst;
            int cardSecond;
            int pointsFirst=0;
            int pointsSecond=0;

            while (input!="End of game")
            {
                cardFirst=int.Parse(input);
                cardSecond=int.Parse(Console.ReadLine()); 
                if(cardFirst>cardSecond)
                {
                    pointsFirst+=cardFirst-cardSecond;
                }
                else if (cardFirst<cardSecond)
                {
                    pointsSecond+=cardSecond - cardFirst;
                }
                else if(cardFirst==cardSecond)
                {
                    Console.WriteLine($"Number wars!");
                    int cF = int.Parse(Console.ReadLine());
                    int cS = int.Parse(Console.ReadLine());
                    if(cF>cS)
                    {
                        pointsFirst=cF-cS;
                        Console.WriteLine($"{nameFirstPlaye} is winner with {pointsFirst} points");
                    }
                    else if (cS>cF) 
                    {
                        pointsSecond=cS-cF;
                        Console.WriteLine($"{nameSecondPlaye} is winner with {pointsSecond} points");
                    }
                    break;
                }
                input = Console.ReadLine();
            }
            if(input== "End of game")
            {
                Console.WriteLine($"{nameFirstPlaye} has {pointsFirst} points");
                Console.WriteLine($"{nameSecondPlaye} has {pointsSecond} points");
            }
            
        }
    }
}
