using System;

namespace Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours=int.Parse(Console.ReadLine());
            string day=Console.ReadLine();

            if (hours>=10&&hours<18)
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine("open");
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine("closed");
                        break;

                }

            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
