using System;

namespace Stream_Of_Letters_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

                string input = Console.ReadLine();
                string secretCommand = "";
                string word = "";

                while (input != "End")
                {
                    if (char.IsLetter(input[0]))
                    {
                        if (input[0] == 'c' || input[0] == 'o' || input[0] == 'n')
                        {
                            secretCommand += input[0];
                        }
                        else
                        {
                            if (secretCommand.Length == 3)
                            {
                                word += input;
                            }
                        }
                    }

                    if (secretCommand == "con")
                    {
                        Console.Write(word + " ");
                        word = "";
                        secretCommand = "";
                    }

                    input = Console.ReadLine();
                }
            }
        }



    }


