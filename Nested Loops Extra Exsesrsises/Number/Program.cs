using System;

namespace Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    for (int k = start; k <= end; k++)
                    {
                        for (int n = start; n <= end; n++)
                        {
                            if (i % 2 == 0 && n % 2 != 0)
                            {
                                if (i > n)
                                {
                                    if ((j + k) % 2 == 0)
                                    {
                                        Console.WriteLine($"{i}{j}{k}{n}");
                                    }
                                }
                            }
                            else if (i % 2 != 0 && n % 2 == 0)
                                if (i > n)
                                {
                                    if ((j + k) % 2 == 0)
                                    {
                                        Console.WriteLine($"{i}{j}{k}{n}");
                                    }
                                }
                        }

                    }
                }

            }
        }
    }
}
