namespace Freezing_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempCelsius = int.Parse(Console.ReadLine());

            if (tempCelsius <= 0)
            {
                Console.WriteLine("Freezing weather!");
            }
        }
    }
}
