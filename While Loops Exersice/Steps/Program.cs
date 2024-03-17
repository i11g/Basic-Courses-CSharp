using System;

namespace Steps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            string input;
            int sumOfSteps = 0;

            while ((input = Console.ReadLine()) != "Going home")
            {
                steps = int.Parse(input);
                sumOfSteps += steps;
                if (sumOfSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{sumOfSteps - 10000} steps over the goal!");
                    break;
                }
            }
            
            if (input == "Going home")
                {
                    int additionalSteps = int.Parse(Console.ReadLine());
                    sumOfSteps += additionalSteps;
                    if (sumOfSteps < 10000) 
                { Console.WriteLine($"{10000 - sumOfSteps} more steps to reach goal."); }
                    else
                    {
                        Console.WriteLine($"Goal reached! Good job!");
                        Console.WriteLine($"{sumOfSteps - 10000} steps over the goal!");
                    }

                }
            }
        }
    }

