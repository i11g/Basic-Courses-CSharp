using System;
using System.Net.Http.Headers;

namespace Generator_of_Save_Passwords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endX=int.Parse(Console.ReadLine());
            int endY=int.Parse(Console.ReadLine());
            int maxCombination=int.Parse(Console.ReadLine());

            int counter = 0; 

            for (int A = 35; A <=55; A++)
            {
                if(counter>maxCombination)
                {
                    break;
                }
                for (int B = 64; B <=96; B++)
                {
                    if (counter>maxCombination)
                    {
                        break;
                    }
                    for (int x = 1; x <=endX; x++)
                    {
                        if (counter>maxCombination)
                        {
                            break;
                        }
                        for (int y = 1; y <= endY; y++)
                        {

                            if (counter > maxCombination)
                            {
                                break;
                            }
                            
                            Console.Write($"{(char)A}{(char)B}{x}{y}|{(char)B}{(char)A}");
                            counter++;
                        }
                    }
                }
            }
        }
    }
}
