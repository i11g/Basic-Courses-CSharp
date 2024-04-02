using System;

namespace Suppliers_For_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paketsPencils=int.Parse(Console.ReadLine());
            int paketsMarkers=int.Parse(Console.ReadLine());
            int liters=int.Parse(Console.ReadLine());
            int percentileDiscount=int.Parse(Console.ReadLine());

            double sum = paketsPencils * 5.80 + paketsMarkers * 7.20 + liters * 1.20;
            double discount = sum * percentileDiscount / 100;
            double totalSum=sum-discount;
            Console.WriteLine(totalSum);
        }
    }
}
