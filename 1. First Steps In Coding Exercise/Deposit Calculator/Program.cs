using System;

namespace Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum=double.Parse(Console.ReadLine());
            int termsMonts=int.Parse(Console.ReadLine());
            double interestPercentile = double.Parse(Console.ReadLine());

            double interestSum = (((depositSum * interestPercentile) / 100) * termsMonts) / 12;
            double totalSum = depositSum + interestSum;
            Console.WriteLine(totalSum);
        }
    }
}
