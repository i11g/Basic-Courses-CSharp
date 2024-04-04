using System;

namespace On_time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoursExam=int.Parse(Console.ReadLine());
            int minutesExam=int.Parse(Console.ReadLine());
            int hoursArriving=int.Parse(Console.ReadLine());
            int minutesArriving=int.Parse(Console.ReadLine());

            int totalMinutesExam = hoursExam * 60 + minutesExam;
            int totalMinutesArriving = hoursArriving * 60 + minutesArriving;

           if (totalMinutesArriving<totalMinutesExam)
            {
                if (hoursArriving<=(totalMinutesExam-30)) 
                {
                    int diff = totalMinutesExam - totalMinutesArriving;
                    Console.WriteLine("On time");
                    Console.WriteLine($"{diff} minutes before the start");
                }
                else  
                { 
                    Console.WriteLine("Early");
                    int diff = totalMinutesExam - totalMinutesArriving;
                    if (diff > 60)
                    {
                        int hours = diff / 60;
                        int minutes = diff % 60;
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                    else 
                    {
                        Console.WriteLine($"{diff} minutes before the start");
                    }
                }
            }
            else if (totalMinutesArriving>totalMinutesExam)
            {
                Console.WriteLine("Late");
                int diff=totalMinutesArriving-totalMinutesExam;
                if (diff>60)
                {
                    int hours=diff/60;
                    int minutes=diff%60;
                    Console.WriteLine($"{hours}:{minutes} hours after the start");
                }
                else 
                {
                    Console.WriteLine($"{diff} minutes after the start");
                }
            }
            else if (totalMinutesExam == totalMinutesArriving)
            {
                Console.WriteLine("On time");

            }
        }
    }
}
