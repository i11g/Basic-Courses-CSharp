﻿using System;

namespace Combinations_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start=char.Parse(Console.ReadLine());
            char end=char.Parse(Console.ReadLine());
            char miss=char.Parse(Console.ReadLine());
            int combinations = 0;
            
            for (char i = start; i <=end; i++)
            {
                for(char j = start; j <=end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i == miss || j == miss || k == miss)
                        {
                            continue;
                        }
                        combinations++;
                        Console.Write($"{i}{j}{k} "); 
                        
                    }
                }
            }
            Console.Write($"{combinations}");
        }
    }
}
