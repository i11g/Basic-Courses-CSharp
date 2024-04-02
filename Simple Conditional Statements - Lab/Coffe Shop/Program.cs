namespace Coffe_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDrink=Console.ReadLine();  
            string extra=Console.ReadLine();

            double totalPrice = 0;

            if(typeOfDrink =="coffee"&&extra=="no")
            {
                totalPrice = 1.0;
            }
            else if(typeOfDrink =="coffee"&&extra=="sugar") { totalPrice = 1.40; }
            else if (typeOfDrink == "tea" && extra == "no")
            {
                totalPrice = 0.60;
            }
            else if (typeOfDrink == "tea" && extra == "sugar") { totalPrice = 1.00; }
            Console.WriteLine($"Final price: ${totalPrice:f2}");
        }
    }
}