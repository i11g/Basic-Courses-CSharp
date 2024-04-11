using System;

namespace Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input=Console.ReadLine();
            string name;
            int numberOfGoals = 0;
            int maxGoals = int.MinValue;
            string maxName = "";

            while (input!="END")
            {
                name = input;
                numberOfGoals=int.Parse(Console.ReadLine());

                if (numberOfGoals > maxGoals)
                {
                    maxGoals = numberOfGoals;
                    maxName = name;
                }
                if (maxGoals >= 10)
                {
                    break;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"{maxName} is the best player!");
            if (maxGoals >= 3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
        }
    }
}
