using System;

namespace Stream_of_letters_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string word = "";
            bool isCFound = false;
            bool isOFound = false;
            bool isNFound = false;
            int cCount = 0;
            int oCount = 0;
            int nCount = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                char character = input[0];

                if (char.IsLetter(character))
                {

                    if (character == 'c')
                    {
                        isCFound = true;
                        cCount++;
                        continue;
                    }
                    else if (character == 'o')
                    {
                        isOFound = true;
                        oCount++;
                        continue;
                    }
                    else if (character == 'n')
                    {
                        isNFound = true;
                        nCount++;
                        continue;
                    }
                    if (cCount > 1)
                    {
                        word += character == 'c';
                    }

                    else if (oCount > 1)
                    {
                        word += character == 'o';
                    }
                    else if (nCount > 1)
                    {
                        word += character == 'n';
                    }
                }

                word += character;

                if (isCFound && isNFound && isOFound)
                {
                    Console.Write(word + " ");
                    word = "";
                }

                isCFound = false;
                isOFound = false;
                isNFound = false;
            }
            Console.WriteLine(word);
        }
    }
}



