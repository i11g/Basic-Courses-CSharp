using System;

namespace Lucky_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lucky=int.Parse(Console.ReadLine());

            for (int i = 1; i <=9; i++)
            {
                for (int j = 1; j <=9; j++)
                {
                    for (int k = 1; k <=9; k++)
                    {
                        for (int n = 1; n <=9; n++)
                        {
                            if(i+j==k+n)
                            {
                                if(lucky%(i+j)==0)
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
