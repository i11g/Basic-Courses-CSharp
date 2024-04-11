using System;

namespace Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls=int.Parse(Console.ReadLine());
            double totalPoints = 0;
            string colour = "";
            int dividesBlack = 0;
            int othresCollors = 0;
            int red = 0;
            int yellow = 0;
            int orange = 0;
            int white = 0;

            for (int i = 1; i <=numberOfBalls; i++)
            {
                colour = Console.ReadLine();
                if(colour =="red")
                {
                    totalPoints += 5;
                    red++;
                }
                else if(colour =="orange")
                {
                    totalPoints += 10;
                    orange++;
                }
                else if (colour == "yellow")
                {
                    totalPoints += 15;
                    yellow++;
                }
                else if (colour == "white")
                {
                    totalPoints += 20;
                    white++;
                }
                else if (colour == "black")
                {
                    totalPoints /= 2;
                    dividesBlack++;
                }
                else
                {
                    othresCollors++;
                }
            }
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {othresCollors}");
            Console.WriteLine($"Divides from black balls: {dividesBlack}");
           

        }
    }
}
