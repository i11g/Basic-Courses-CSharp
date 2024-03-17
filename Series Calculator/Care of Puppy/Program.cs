using System;

namespace Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int food = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int foodGrams = food * 1000;

            while (input != "Adopted")
            {
                int eatedFood = int.Parse(input);
                foodGrams -= eatedFood;
                input=Console.ReadLine();
            }
            if (foodGrams >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodGrams} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodGrams)} grams more.");

            }
        }
    }
}
