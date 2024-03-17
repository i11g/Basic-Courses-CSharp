using System;

namespace Sum_Of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber;

            while(number>sum)
            {   
                currentNumber=int.Parse(Console.ReadLine());
                sum += currentNumber;

                
            }
            Console.WriteLine(sum);
        }
    }
}
