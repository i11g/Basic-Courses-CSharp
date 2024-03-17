using System;

namespace Operations_With_Whole_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double number1=double.Parse(Console.ReadLine());
           double number2=double.Parse(Console.ReadLine());
            string type=Console.ReadLine();
            double result = 0;

            if (type == "+")
            {
                result = number1 + number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - odd");
                }
            }
            else if (type == "-")
            {
                result = number1 - number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - odd");
                }
            }
            else if (type == "*")
            {
                result = number1 * number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - odd");
                }
            }
            else if (type == "/")
            {

                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    result = number1 / number2;

                    Console.WriteLine($"{number1} / {number2} = {result:f2}");
                }
            }
            else
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    result = number1 % number2;

                    Console.WriteLine($"{number1} % {number2} = {result}");
                }
            }
        }
    }
}
