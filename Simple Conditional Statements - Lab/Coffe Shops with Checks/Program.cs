namespace Coffe_Shops_with_Checks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDrink = Console.ReadLine();
            string extra = Console.ReadLine();

            double totalPrice = 0;
            bool isValid = true;

            switch (typeOfDrink)
            {
                case "coffee":
                    totalPrice = 1.00;
                    break;
                case "tea":
                    totalPrice = 0.60;
                    break;
                default:
                    Console.WriteLine("Unknown drink");
                    isValid = false;
                    break;
            }
            if (isValid)
            {
                switch (extra)
                {
                    case "sugar":
                        totalPrice += 0.40;
                        break;
                    case "no":
                        totalPrice = totalPrice;
                        break;
                    default:
                        Console.WriteLine("Unknown extra");
                        isValid = false;
                        break;

                }
            }
                    
            
            if (isValid)
            {
               Console.WriteLine($"Final price: ${totalPrice:f2}");
            }



        }
    }
}