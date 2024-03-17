using System;

namespace Easter_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int startingEggs=int.Parse(Console.ReadLine());
            string input=Console.ReadLine();
            string command;
            int additionalNumberOFEggs = 0;
            int eggsLeft = 0;
            int soldeggs = 0;

            while(input!="Close")
            {
                command = input;
                additionalNumberOFEggs=int.Parse(Console.ReadLine());
                if(command=="Buy")
                {
                    startingEggs-=additionalNumberOFEggs;
                    soldeggs += additionalNumberOFEggs; 
                    if(startingEggs<0)
                    {
                        eggsLeft = additionalNumberOFEggs - Math.Abs(startingEggs);
                        break;
                    }
                }
                else
                {
                    startingEggs += additionalNumberOFEggs;
                }
                input= Console.ReadLine();
                
            }
            if(input=="Close")
            {
                Console.WriteLine($"Store is closed!");
                Console.WriteLine($"{soldeggs} eggs sold.");
            }
            else if (startingEggs<0)
            {
                Console.WriteLine($"Not enough eggs in store!");
                Console.WriteLine($"You can buy only {eggsLeft }.");
            }
        }
    }
}
