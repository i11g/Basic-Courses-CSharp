using System;

namespace Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country=Console.ReadLine();
            string device=Console.ReadLine();
            double totalpoints = 0;

            if (country =="Russia")
            {
                if(device =="ribbon")
                {
                    totalpoints = 9.100 + 9.4000;
                }
                else if (device =="hoop")
                {
                    totalpoints = 9.3000 + 9.800;
                }
                else if(device =="rope")
                {
                    totalpoints = 9.6000 + 9.000;

                }
            }
            else if (country == "Bulgaria")
            {
                if (device == "ribbon")
                {
                    totalpoints = 9.600 + 9.4000;
                }
                else if (device == "hoop")
                {
                    totalpoints = 9.550 + 9.750;
                }
                else if (device=="rope")
                {
                    totalpoints = 9.5000 + 9.400;

                }
            }
            else 
            {
                if (device == "ribbon")
                {
                    totalpoints = 9.200 + 9.5000;
                }
                else if (device == "hoop")
                {
                    totalpoints = 9.450 + 9.350;
                }
                else if (device == "rope"  )
                {
                    totalpoints = 9.700 + 9.150;

                }
            }
            Console.WriteLine($"The team of {country} get {totalpoints:f3} on {device}");
            Console.WriteLine($"{(20-totalpoints)/20*100:f2}%");
        }
    }
}
