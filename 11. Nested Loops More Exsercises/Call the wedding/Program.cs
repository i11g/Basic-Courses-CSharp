using System;

namespace Call_the_wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clientsMen = int.Parse(Console.ReadLine());
            int clientsWomenn = int.Parse(Console.ReadLine());
            int numberOfTable = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int i = 1; i <= clientsMen; i++)
            {
                for (int j = 1; j <= clientsWomenn; j++)
                {
                    combinations++;
                    Console.Write($"{i}<->{j} ");
                    if (combinations==numberOfTable)
                    {
                        break;
                    }
                    
                }
            }
        }
    }
}
