using System;

namespace Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBolls=int.Parse(Console.ReadLine());
            int points = 0;
            int redballs = 0;
            int orangeballs = 0;
            int yellowballs = 0;
            int whiteballs = 0;
            int blackballs = 0;
            int otherballs = 0;

            for (int balls = 1; balls <=numberOfBolls; balls++)
            {
                string collorOfbolls = Console.ReadLine();
                if (collorOfbolls =="red")
                {
                    points += 5;
                    redballs++;
                }
                else if (collorOfbolls =="orange")
                {
                    points += 10;
                    orangeballs++;
                }
                else if (collorOfbolls == "yellow")
                {
                    points += 15;
                    yellowballs++;
                }
                else if (collorOfbolls == "white")
                {
                    points += 20;
                    whiteballs++;
                }
                else if (collorOfbolls == "black")
                {
                    points/= 2;
                    blackballs++;
                }
                else
                {
                    points = points;
                    otherballs++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redballs}");
            Console.WriteLine($"Orange balls: {orangeballs}");
            Console.WriteLine($"Yellow balls: {yellowballs}");
            Console.WriteLine($"White balls: {whiteballs}");
            Console.WriteLine($"Other colors picked: {otherballs}");
            Console.WriteLine($"Divides from black balls: {blackballs}");


        }
    }
}
