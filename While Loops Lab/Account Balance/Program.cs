using System;

namespace Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input=Console.ReadLine();
            double total = 0; 

            while(input != "NoMoreMoney")
            {
                double sum=double.Parse(input);
                if (sum < 0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {sum:f2}");
                total+= sum;

                input= Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
