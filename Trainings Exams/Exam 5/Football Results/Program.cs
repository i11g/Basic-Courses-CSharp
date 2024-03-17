using System;

namespace Football_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultFirstGame=Console.ReadLine();
            string resultSecondtGame=Console.ReadLine();
            string resultThirdtGame=Console.ReadLine();
            int wins = 0;
            int lost = 0;
            int draw = 0;

            char first = resultFirstGame[0];
            char second = resultFirstGame[2];
            if(first >second)
            {
                wins++;
            }
            else if(second >first)
            {
                lost++;
            }
            else if(first ==second) 
            {
                draw++;
            }
            char firstS = resultSecondtGame[0];
            char secondS = resultSecondtGame[2];
            if (firstS > secondS)
            {
                wins++;
            }
            else if (secondS > firstS)
            {
                lost++;
            }
            else if (firstS == secondS)
            {
                draw++;
            }
            char firstT = resultThirdtGame[0];
            char secondT = resultThirdtGame[2];
            if (firstT > secondT)
            {
                wins++;
            }
            else if (secondT > firstT)
            {
                lost++;
            }
            else if (firstT == secondT)
            {
                draw++;
            }
            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn Games {draw} games.");
        }
    }
}
