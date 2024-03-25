using System;

namespace Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string eggsSize=Console.ReadLine();
           string eggsColour=Console.ReadLine();
            int numberOfQuality=int.Parse(Console.ReadLine());
            int income = 0;
            double expenses = 0;


            if (eggsSize =="Large")
            {
                if (eggsColour =="Red")
                {
                    income = numberOfQuality * 16;
                }
                else if (eggsColour =="Green")
                {
                    income = numberOfQuality * 12;
                }
                else
                {
                    income = numberOfQuality*8;
                }
            }
            else if (eggsSize == "Medium")
            {
                if (eggsColour == "Red")
                {
                    income = numberOfQuality * 13;
                }
                else if (eggsColour == "Green")
                {
                    income = numberOfQuality * 9;
                }
                else
                {
                    income = numberOfQuality * 7;
                }
            }
            else 
            {
                if (eggsColour == "Red")
                {
                    income = numberOfQuality * 9;
                }
                else if (eggsColour == "Green")
                {
                    income = numberOfQuality * 8;
                }
                else
                {
                    income = numberOfQuality * 5;
                }
            }
            expenses = income * 0.35;
            Console.WriteLine($"{(income - expenses):f2} leva.");
        }
    }
}
