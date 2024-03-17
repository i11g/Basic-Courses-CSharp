using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int wigth = int.Parse(Console.ReadLine());

            int numberOfCakes = length * wigth;

            string input=Console.ReadLine();
            int totalPieces = 0;

            while(input!="STOP")
            {
                int pieces = int.Parse(input);
                totalPieces += pieces;
                if(totalPieces > numberOfCakes)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (input=="STOP")
            {
                Console.WriteLine($"{numberOfCakes - totalPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {totalPieces - numberOfCakes} pieces more.");
            }


        }
    }
}
