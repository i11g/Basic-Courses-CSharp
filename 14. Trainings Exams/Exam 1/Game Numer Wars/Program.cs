using System;

namespace Game_Numer_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameFirst = Console.ReadLine();
            string nameSecond = Console.ReadLine();

            string input= Console.ReadLine();
            int firstCard = 0;
            int secondCard = 0;
            int sumFirstCard = 0;
            int sumSecondCard = 0;
            while(input!= "End of game") 
            { 
                firstCard=int.Parse(input);
                secondCard=int.Parse(Console.ReadLine());
                if (firstCard > secondCard)
                {
                    sumFirstCard += firstCard - secondCard;
                }
                else if (firstCard < secondCard)
                {
                    sumSecondCard += secondCard-firstCard;
                }
                else if(firstCard==secondCard)
                {
                  
                    break;
                }
                input=Console.ReadLine();
            }
            if (input== "End of game")
            {
                Console.WriteLine($"{nameFirst} has {sumFirstCard} points");
                Console.WriteLine($"{nameSecond} has {sumSecondCard} points");
            }
            if(firstCard==secondCard)
            {
                Console.WriteLine($"Number wars!");
                int one = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                if (one > second)
                {
                    Console.WriteLine($"{nameFirst} is winner with {sumFirstCard} points");
                }
                else
                {
                    Console.WriteLine($"{nameSecond} is winner with {sumSecondCard} points");
                }
            }
        }
    }
}
