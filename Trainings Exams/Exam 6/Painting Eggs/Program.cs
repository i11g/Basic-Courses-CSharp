using System;

namespace Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eggsSize=Console.ReadLine();
            string eggsCollor=Console.ReadLine();
            int numberpattidi=int.Parse(Console.ReadLine());
            double expenses = 0;

            if (eggsSize=="Large")
            {
                if (eggsCollor=="Red")
                {
                    expenses =numberpattidi*16;
                }
                else if (eggsCollor == "Green")
                {
                    expenses =numberpattidi*12;
                }
                else
                {
                    expenses=numberpattidi*9;
                }
            }
            else if (eggsSize == "Medium")
            {
                if (eggsCollor == "Red")
                {
                    expenses = numberpattidi * 13;
                }
                else if (eggsCollor == "Green")
                {
                    expenses = numberpattidi * 9;
                }
                else
                {
                    expenses = numberpattidi * 7;
                }
            }
            else if (eggsSize == "Small")
            {
                if (eggsCollor == "Red")
                {
                    expenses = numberpattidi * 9;
                }
                else if (eggsCollor == "Green")
                {
                    expenses = numberpattidi * 8;
                }
                else
                {
                    expenses = numberpattidi * 5;
                }
            }
            expenses -= expenses * 0.35;
            Console.WriteLine($"{expenses:f2} leva.");

        }
    }
}
