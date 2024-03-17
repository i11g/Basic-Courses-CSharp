using System;

namespace Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesWalking=int.Parse(Console.ReadLine());
            int numbersOfWalking=int.Parse(Console.ReadLine());
            int caloriesTaken=int.Parse(Console.ReadLine());

            int calloriesUsed = minutesWalking * numbersOfWalking * 5;
            if(calloriesUsed > caloriesTaken/2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {calloriesUsed}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {calloriesUsed}.");
            }
        }
    }
}
