using System;

namespace Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfVisitors=int.Parse(Console.ReadLine());
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake=0;
            int proteinBar=0;

            for (int i = 1; i <=numberOfVisitors; i++)
            {
                string activity=Console.ReadLine();
                if(activity =="Back")
                {
                    back++;
                }
                else if (activity == "Chest")
                {
                    chest++;
                }
                else if (activity == "Legs")
                {
                    legs++;
                }
                else if (activity == "Abs")
                {
                    abs++;
                }
                else if (activity == "Protein shake")
                {
                    proteinShake++;
                }
                else if (activity == "Protein bar")
                {
                    proteinBar++;
                }
                Console.WriteLine($"{back}-back");
            }
        }
    }
}
