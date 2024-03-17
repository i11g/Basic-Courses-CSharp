using System;

namespace Number_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfstudents=int.Parse(Console.ReadLine());
            int fail = 0;
            int studentsGood = 0;
            int studentsVeryGood = 0;
            int topStudents = 0;
            double grade;
            double totalGrade=0;

            for (int i = 1; i <=numberOfstudents; i++)
            {
                grade=double.Parse(Console.ReadLine());
                totalGrade += grade;

                if(grade<=2.99)
                {
                    fail++;
                }
                else if(grade<=3.99)
                {
                    studentsGood++;
                }
                else if(grade<=4.99)
                {
                    studentsVeryGood++;
                }
                else
                {
                    topStudents++;
                }
            }
            Console.WriteLine($"Top students: {(double)topStudents / numberOfstudents * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double) studentsVeryGood / numberOfstudents * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double) studentsGood / numberOfstudents * 100:f2}%");
            Console.WriteLine($"Fail: {(double)fail / numberOfstudents * 100:f2}%");
            Console.WriteLine($"Average: {totalGrade/numberOfstudents:f2}");
        }
    }
}
