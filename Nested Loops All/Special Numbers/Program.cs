using System;

namespace Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());

            for (int firstNumber = 1; firstNumber <=9 ; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <=9; secondNumber++)
                {
                    for (int thirdNumber = 1; thirdNumber <=9; thirdNumber++)
                    {
                        for (int fourthNumber = 1; fourthNumber <=9; fourthNumber++)
                        {
                            if(n%firstNumber==0&&n%secondNumber==0&&n%thirdNumber==0&&n%fourthNumber==0)
                            {
                                Console.Write($"{firstNumber}{secondNumber}{thirdNumber}{fourthNumber} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
