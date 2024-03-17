using System;
using System.Security.Cryptography;

namespace Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            string activity;
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;
            int totalTraining = 0;
            int totalProducts = 0;

            for (int i = 0; i < number; i++)
            {
                activity = Console.ReadLine();
                if (activity =="Back")
                {
                    back++;
                    totalTraining++;
                }
                else if (activity =="Chest")
                {
                    chest++;
                    totalTraining++;
                }
                else if (activity == "Legs")
                {
                    legs++;
                    totalTraining++;
                }
                else if (activity == "Abs")
                {
                    abs++;
                    totalTraining++;
                }
                else if (activity == "Protein shake")
                {
                    proteinShake++;
                    totalProducts++;
                }
                else if (activity == "Protein bar")
                {
                    proteinBar++;
                    totalProducts++;
                }
            }
            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{(double)totalTraining / number * 100:f2}% - work out");
            Console.WriteLine($"{(double)totalProducts / number * 100:f2}% - protein");


        }
    }
}
