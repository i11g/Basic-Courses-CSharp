using System;

namespace Equal_Sum_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int firstNumber=int.Parse(Console.ReadLine());
            int secondNumber=int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <=secondNumber; i++) 
            {
                string currentNumber = i.ToString();
                int sumOdd = 0;
                int sumEven = 0;
                
                for (int j = 0; j<currentNumber.Length; j++)
                {
                    
                    int number = int.Parse(currentNumber[j].ToString());
                    
                    if (j%2==0)
                    {
                        sumEven += number;
                    }
                    else 
                    {
                        sumOdd += number;
                    }
                    
                }
                if (sumEven == sumOdd)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
