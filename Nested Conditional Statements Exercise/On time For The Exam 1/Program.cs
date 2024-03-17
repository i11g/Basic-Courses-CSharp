using System;

namespace On_time_For_The_Exam_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfTheExam=int.Parse(Console.ReadLine());
            int minutesOfTheExam=int.Parse(Console.ReadLine());
            int hourArriving=int.Parse(Console.ReadLine());
            int minutesArriving=int.Parse(Console.ReadLine());

            minutesOfTheExam += hourOfTheExam * 60;
            minutesArriving += hourArriving * 60;
            int diff = minutesArriving - minutesOfTheExam;
            int diff1 = minutesOfTheExam - minutesArriving;

            if (diff<60&&diff>0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{diff} minutes after the start");
            }
            else if (diff > 0&&diff>=60) 
            {   
                int hour=diff/60;
                int minutes=diff%60;
                Console.WriteLine("Late");
                Console.WriteLine($"{hour}:{minutes:D2} hours after the start");
            }
            if (diff1 <= 30 && diff1 > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{diff1} minutes before the start");

            }
            else if (diff1==0)
            {
                Console.WriteLine("On time");

            }
            else if (diff1 > 0 && diff1 > 30&&diff1<60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{diff1} minutes before the start");

            }
            else if (diff1> 0&& diff1>=60)
            {
                int hour = diff1 / 60;
                int minutes = diff1 % 60;
                Console.WriteLine("Early");
                Console.WriteLine($"{hour}:{minutes:D2} hours before the start");
            }

        }
    }
}
