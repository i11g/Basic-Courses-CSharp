using System;

namespace Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            string input=Console.ReadLine();
            string field = "";
            int currentpoints;
            int points = 301;
            int sucssesShots = 0;
            int unsucssesShots = 0;
            
            while(input!= "Retire")
            {
                field = input;
                currentpoints = int.Parse(Console.ReadLine());
                if(field=="Single")
                {
                    points -= currentpoints;
                    if (points < 0)
                    {
                        unsucssesShots++;
                        points += currentpoints ;

                    }
                    else
                    {
                        sucssesShots++;
                    }
                }
                else if (field == "Double")
                {
                    points -= currentpoints*2;
                    if (points < 0)
                    {
                        unsucssesShots++;
                        points += currentpoints * 2;
                    }
                    else
                    {
                        sucssesShots++;
                    }
                }
                else if (field == "Triple")
                {
                    points -= currentpoints * 3;
                    if (points < 0)
                    {
                        unsucssesShots++;
                        points += currentpoints * 3;

                    }
                    else
                    {
                        sucssesShots++;
                    }
                }
                if(points==0)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (points==0)
            {
                Console.WriteLine($"{name} won the leg with {sucssesShots} shots.");
            }
            if(input=="Retire")
            {
                Console.WriteLine($"{name} retired after {unsucssesShots} unsuccessful shots.");
            }
        }
    }
}
