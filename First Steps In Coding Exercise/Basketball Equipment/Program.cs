using System;

namespace Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int payment = int.Parse(Console.ReadLine());

            double trainers = payment - payment * 0.4;
            double outfit = trainers - trainers * 0.2;
            double ball = outfit * 0.25;
            double acesessories = ball * 0.20;

            double total = trainers + outfit + acesessories + ball+payment;
            Console.WriteLine(total);
        }
    }
}
