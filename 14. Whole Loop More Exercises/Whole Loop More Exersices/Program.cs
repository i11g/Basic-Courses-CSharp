using System;
using System.Threading.Channels;

namespace Whole_Loop_More_Exersices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBottles=int.Parse(Console.ReadLine());
            int detergentAmount = numberOfBottles * 750;
            string input=Console.ReadLine();
            int countNumberOfDishes = 0;
            int totalNumber = 0;
            int numberOfPots = 0;

            while (input != "End")
            {
                int numberOfDishes = int.Parse(input);
                countNumberOfDishes++;
                totalNumber+=numberOfDishes;
                if (countNumberOfDishes < 3)
                {
                    detergentAmount -= numberOfDishes * 5;
                }
                else if (countNumberOfDishes == 3)
                {   
                    numberOfPots+=numberOfDishes;
                    detergentAmount -= numberOfDishes *15;
                    countNumberOfDishes = 0;
                }
                if (detergentAmount < 0)
                {
                    break;
                }
                input=Console.ReadLine();
            }
            if (input=="End")
            {
                Console.WriteLine($"Detergent was enough!"); 
                Console.WriteLine($"{totalNumber-numberOfPots} dishes and {numberOfPots} pots were washed."); 
                Console.WriteLine($"Leftover detergent {detergentAmount} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {detergentAmount} ml. more necessary!");
            }
                


            }
        }
    }

