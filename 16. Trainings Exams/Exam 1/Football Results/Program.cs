using System;

namespace Football_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultFirstGame=Console.ReadLine();
            string resultSecondGame=Console.ReadLine();
            string resultThirdGame=Console.ReadLine();
            int wonGames = 0;
            int lostGames = 0;
            int drawGames = 0;

            char goalsFirstGame = (resultFirstGame[0]);
            int goalsOne=int.Parse(goalsFirstGame.ToString());
            char goalsFisrtGameSec = (resultFirstGame[2]);
            int goalsTwo = int.Parse(goalsFisrtGameSec.ToString());
            if(goalsOne>goalsTwo)
            {
                wonGames++;
            }
            else if(goalsTwo>goalsOne)
            {
                lostGames++;
            }
            else
            {
                drawGames++;
            }
            char goalsSecGame = (resultSecondGame[0]);
            int goalsOneS = int.Parse(goalsSecGame.ToString());
            char goalsSecGameSec = (resultSecondGame[2]);
            int goalsTwoS = int.Parse(goalsSecGameSec.ToString());
            if (goalsOneS > goalsTwoS)
            {
                wonGames++;
            }
            else if (goalsTwoS > goalsOneS)
            {
                lostGames++;
            }
            else
            {
                drawGames++;
            }
            char goalsThirdGame = (resultThirdGame[0]);
            int goalsOneT = int.Parse(goalsThirdGame.ToString());
            char goalsSecGameT = (resultThirdGame[2]);
            int goalsTwoT = int.Parse(goalsSecGameT.ToString());
            if (goalsOneT > goalsTwoT)
            {
                wonGames++;
            }
            else if (goalsTwoT > goalsOneT)
            {
                lostGames++;
            }
            else
            {
                drawGames++;
            }

            Console.WriteLine($"Team won {wonGames}");
            Console.WriteLine($"Team lost {lostGames}");
            Console.WriteLine($"Team draw {drawGames}");
        }
    }
}
