using System;
using System.ComponentModel.Design;

namespace Tournament_Of_Cristmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays=int.Parse(Console.ReadLine());
            string input;
            string sport;
            double wonMoneyTotal = 0;
            int totalLost = 0;
            int totalWon = 0;

            for (int i = 1; i <=numberOfDays; i++)
            {
                input= Console.ReadLine();
                string outcome; int numberWonGames = 0;
                int numberLoseGames = 0;
                double wonMoney = 0;
                while (input!="Finish")
                {
                    sport = input;
                    outcome = Console.ReadLine();
                    
                    if(outcome=="win")
                    {
                        wonMoney += 20;
                        numberWonGames++;
                    }
                    else
                    {
                        wonMoney += 0;
                        numberLoseGames++;
                    }
                    input= Console.ReadLine();
                }
                if(input=="Finish")
                {
                    if (numberLoseGames<numberWonGames)
                    {
                        wonMoney += wonMoney * 0.10;
                        wonMoneyTotal+=wonMoney;
                        wonMoney = 0;
                    }
                    else
                    {
                        wonMoneyTotal+=wonMoney;
                        wonMoney = 0;
                    }
                    totalLost += numberLoseGames;
                    numberLoseGames = 0;
                    totalWon += numberWonGames;
                    numberWonGames=0;
                }
            }
            if(totalWon>totalLost)
            {
               Console.WriteLine($"You won the tournament! Total raised money: {wonMoneyTotal+=wonMoneyTotal*0.20:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {wonMoneyTotal:f2}");
            }
           
        }
    }
}
