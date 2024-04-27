using System;

namespace Number_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            for (char i =char.Parse(number[2]); i>=0; i--)
            {
                Console.WriteLine(i);
            }



        }
    }
}
