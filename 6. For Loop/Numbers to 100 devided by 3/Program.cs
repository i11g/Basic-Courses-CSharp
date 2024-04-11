using System;

namespace Numbers_to_100_devided_by_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <=100; i++)
            {
                if(i%3==0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
