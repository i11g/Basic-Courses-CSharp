using System;

namespace Operations_with_Numbers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char op= char.Parse(Console.ReadLine());
            double result=0;
            string evenOrOdd=string.Empty;

            switch (op)
            {
                
                case '+':
                    result = number1 + number2;
                    if (result%2==0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";

                    } 
                    break;
                case '-': 
                    result = number1 - number2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";

                    }
                    break;
                case '*': 
                    result = number1 * number2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";

                    }
                    break;
                case '/':
                                        
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                        break;
                    }
                    result =(double) number1 / number2;
                    break;
                case '%':
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                        break;
                    }
                    result = number1 % number2;
                    break;
            }
            if (op == '*' || op == '-' || op == '+')
            {
                Console.WriteLine($"{number1} {op} {number2} = {result} - {evenOrOdd}");
            }
            else if (op=='/'&&number2!=0)
            {
                Console.WriteLine($"{number1} / {number2} = {result:f2}");
            }
            else if (op=='%'&&number2!=0) 
            {
                Console.WriteLine($"{number1} % {number2} = {result}");
            }
        }
    }
}
