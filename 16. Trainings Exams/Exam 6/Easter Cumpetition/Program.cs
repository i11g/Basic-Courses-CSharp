using System;

namespace Easter_Cumpetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBreads=int.Parse(Console.ReadLine());
            int totalPoints = 0;
            string name = "";
            int maxPoints = int.MinValue;
            string maxName = "";

            for (int i = 0; i < numberOfBreads; i++)
            {
                name = Console.ReadLine();
                string input = Console.ReadLine();
                int points = 0;
                while (input != "Stop")
                {
                    points = int.Parse(input);
                    totalPoints += points;
                    input = Console.ReadLine();
                }
                if (input == "Stop")
                {
                    Console.WriteLine($"{name} has {totalPoints} points.");
                    if (totalPoints > maxPoints)
                    {
                        maxPoints = totalPoints;
                        Console.WriteLine($"{name} is the new number 1!");
                        maxName = name;
                    }
                    totalPoints= 0;
                }
            }
            Console.WriteLine($"{maxName} won competition with {maxPoints} points!");




        }
    }
}
