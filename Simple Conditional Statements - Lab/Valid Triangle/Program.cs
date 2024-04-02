namespace Valid_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeA=int.Parse(Console.ReadLine());
            int sizeB=int.Parse(Console.ReadLine());
            int sizeC=int.Parse(Console.ReadLine());

            if((sizeA+sizeB) <= sizeC)
            {
                Console.WriteLine("Invalid Triangle");
            }
            
            else if ((sizeA + sizeC) <= sizeB) 
             {
                Console.WriteLine("Invalid Triangle");
            }
            
            else if ((sizeB + sizeC) <= sizeA)
            {
                Console.WriteLine("Invalid Triangle");
            }
        
            else

            {
                Console.WriteLine("Valid Triangle");
                ;
            }

        }
    }
}