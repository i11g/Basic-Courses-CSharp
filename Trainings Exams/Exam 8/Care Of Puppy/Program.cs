using System;

namespace Care_Of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bougthFood=int.Parse(Console.ReadLine());
            bougthFood = bougthFood * 1000;
            string input=Console.ReadLine();
            int eatedFood;
            int totalEatedFood=0;
            
            while(input!="Adopted")
            {
                eatedFood=int.Parse(input);
                totalEatedFood += eatedFood;
                input = Console.ReadLine();
            }
            if(input=="Adopted")
            {
                if(totalEatedFood > bougthFood)
                {
                    Console.WriteLine($"Food is not enough. You need {totalEatedFood - bougthFood} grams more.");
                }
                else
                {
                    Console.WriteLine($"Food is enough! Leftovers: {bougthFood-totalEatedFood} grams.");
                }
            }
        }
    }
}
