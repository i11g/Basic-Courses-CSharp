using System;

namespace Even_or_Odd_Sum_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber=int.Parse(Console.ReadLine());
            int secondNumber=int.Parse(Console.ReadLine());

            for (int i = firstNumber ; i <=secondNumber; i++)
            {
                string currentNUmber=i.ToString();
                int sumOdd = 0;
                int sumEven = 0;

                for (int j = 0; j <currentNUmber.Length; j++)
                {
                    //int number = int.Parse(currentNUmber[j].ToString());
                    if (j%2==0)
                    {
                        sumEven += currentNUmber[j];
                    }
                    else
                    {
                        sumOdd += currentNUmber[j];
                    }
                }
                if(sumOdd == sumEven)
                {
                    Console.WriteLine(i + " ");
                }
            }     
        }
    }
}
