namespace Guess_The_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwoord = Console.ReadLine();

            if (passwoord == "s3cr3t!")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}