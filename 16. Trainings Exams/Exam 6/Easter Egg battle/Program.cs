using System;

namespace Easter_Egg_battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfeggsF=int.Parse(Console.ReadLine());
            int numberOfeggsS=int.Parse(Console.ReadLine());
            string winner;

            string input=Console.ReadLine();
            while (input != "End")
            {
                winner = input;
                if (winner == "one")
                {
                    numberOfeggsS--;
                }
                else if (winner == "two")
                {
                    numberOfeggsF--;
                }
                if (numberOfeggsS == 0) 
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {numberOfeggsF} eggs left.");
                    break;
                }
                if(numberOfeggsF==0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {numberOfeggsS} eggs left.");
                    break;
                }
                input = Console.ReadLine();
            }
            if(input=="End")
            {
                Console.WriteLine($"Player one has {numberOfeggsF} eggs left.");
                Console.WriteLine($"Player one has {numberOfeggsS} eggs left.");

            }
        }
    }
}
