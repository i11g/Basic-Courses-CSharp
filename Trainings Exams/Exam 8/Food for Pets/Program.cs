using System;

namespace Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays=int.Parse(Console.ReadLine());
            double foodQuantity=double.Parse(Console.ReadLine());
            double eatedFoodDog;
            double eatedFoodCat;
            double totalEatedFoodDog = 0;
            double totalEatedFoodCat = 0;
            double biscuits = 0;
            double total = 0;

            for (int i = 1; i <=numberOfDays; i++)
            {
                eatedFoodDog=int.Parse(Console.ReadLine());
                eatedFoodCat=int.Parse(Console.ReadLine());
                            
                if(i==3)
                {
                    total = eatedFoodDog + eatedFoodCat;
                    biscuits = total * 0.1;
                }
                totalEatedFoodDog += eatedFoodDog;
                totalEatedFoodCat += eatedFoodCat;
            }
            Console.WriteLine($"Total eaten biscuits: {biscuits}gr.");
            Console.WriteLine($"{(totalEatedFoodCat + totalEatedFoodDog) / foodQuantity * 100}% of the food has been eaten.");
            Console.WriteLine($"{totalEatedFoodDog / (totalEatedFoodCat + totalEatedFoodDog) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{totalEatedFoodCat / (totalEatedFoodCat + totalEatedFoodDog) * 100:f2}% eaten from the cat.");
        }
    }
}
