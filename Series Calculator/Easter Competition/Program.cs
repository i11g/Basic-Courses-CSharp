using System;
using System.Xml.Linq;

namespace Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBreads=int.Parse(Console.ReadLine());
            int points = 0;
            int maxpoints = 0;

            for (int breads = 1; breads <= numberOfBreads; breads++)
            {
                string name=Console.ReadLine();
                string input=Console.ReadLine();

                while (input != "Stop")
                {
                    int pointscurrent = int.Parse(input);
                    points += pointscurrent;
                    input = Console.ReadLine();


                    if (maxpoints < points)
                    {
                        maxpoints = points;
                    }
                }
                if (input=="Stop"&&maxpoints==points)
                {
                    Console.WriteLine($"{name} has {points} points.");
                    Console.WriteLine($"{name} is the new number 1!");
                    points = 0;
                }
                else
                {
                    Console.WriteLine($"{name} has {points} points.");
                    points = 0;
                }
                
            }
                       
        }
    }
}
