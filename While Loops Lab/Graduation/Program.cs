using System;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();

            double averageGrade = 0;
            double sum = 0;
            int gradeCount = 0;
            double grade = 0;
            int badGrades = 0;

            while (gradeCount<=12) 
            {
                grade=double.Parse(Console.ReadLine());
                gradeCount++;

                if (grade <= 4)
                {
                    badGrades++;
                    
                    if (badGrades > 1)
                    {
                       break;
                    }
                    continue;
                }
                sum += grade;
                         
            }
            if(badGrades>1)
            {
                Console.WriteLine($"{name} has been excluded at {gradeCount} grade");
            }
            else 
            {
                Console.WriteLine($"{name} graduated. Average grade: {sum/(12):f2}");
            }
            
        }
    }
}
