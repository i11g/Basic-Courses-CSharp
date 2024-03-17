using System;

namespace Sum_Of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startInterval=int.Parse(Console.ReadLine());
            int endInterval=int.Parse(Console.ReadLine());
            int magicNumber=int.Parse(Console.ReadLine());
            
            int combination = 0;
            bool isFound=false;
            int result = 0;

            for (int firstNumber = startInterval; firstNumber <=endInterval; firstNumber++)
            {
                for (int secondNumber = startInterval; secondNumber <= endInterval; secondNumber++)
                {
                    combination++;
                    result = firstNumber + secondNumber;
                    
                    if (result==magicNumber)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{combination} ({firstNumber} + {secondNumber} = {magicNumber})");
                        break;
                    }
                    
                } 
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
            
        }
    }
}
