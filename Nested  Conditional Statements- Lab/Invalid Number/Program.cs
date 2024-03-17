using System;

namespace Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            if (number!=0)
            {
                if (number < 100)
                {
                    Console.WriteLine("invalid");
                }
                else if (number >200)
                { Console.WriteLine("invalid"); }

            }
        }
    }
}
