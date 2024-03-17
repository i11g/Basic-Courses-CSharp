using System;
using System.Diagnostics;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double average = 0;
            double sum = 0;

            for (int i = 0; i < number; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5)
                {
                    sum1++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    sum2++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    sum3++;
                }
                else if (grade < 3.00)
                {
                    sum4++;
                }
                sum += grade;
            }
            average = sum / number;
            double percentile1=sum1/number*100;
            double percentile2=sum2/number*100;
            double percentile3=sum3/number*100;
            double percentile4=sum4/number*100;
            Console.WriteLine($"Top students: {percentile1:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentile2:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentile3:f2}%");
            Console.WriteLine($"Fail:{percentile4:f2}%");
            Console.WriteLine($"Average: {average:f2}%");
        }
    }
}
