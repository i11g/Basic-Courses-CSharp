namespace Area_Of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure=Console.ReadLine();

            double area = 0;
            if(typeOfFigure=="square")
            {
                double size=double.Parse(Console.ReadLine());
                area=size*size;
                Console.WriteLine($"{area:F2}");
            }
            else if(typeOfFigure =="rectangle")
            {
                double sideA=double.Parse(Console.ReadLine());
                double sideB=double.Parse(Console.ReadLine());
                area= sideA*sideB;
                Console.WriteLine($"{area:F2}");
            }
            else if(typeOfFigure=="circle")
            {
                double radius=double.Parse((Console.ReadLine()));
                area=Math.PI*radius*radius;
                Console.WriteLine($"{area:F2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }

            
        }
    }
}