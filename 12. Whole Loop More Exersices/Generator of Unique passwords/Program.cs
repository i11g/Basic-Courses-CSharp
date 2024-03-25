using System;

namespace Generator_of_Unique_passwords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());

            int counter = 0;
            int A = 35;
            int B = 64;

            for (int x = 1; x <= a; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    char firstChar = (char)A;
                    char secondChar = (char)B;
                    string password = $"{firstChar}{secondChar}{x}{y}{secondChar}{firstChar}";

                    Console.Write(password + "|");
                    counter++;

                    if (counter >= maxCombinations)
                    {
                        Console.WriteLine();
                        return;
                    }

                    B++;
                    if (B > 96)
                    {
                        B = 64;
                    }
                }

                A++;
                if (A > 55)
                {
                    A = 35;
                }
            }

            Console.WriteLine();
        }
    }




}
