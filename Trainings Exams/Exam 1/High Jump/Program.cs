using System;

namespace High_Jump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int desiredHigh=int.Parse(Console.ReadLine());
            int jumpHigh=0;
            int jumps = 0;
            bool isFailed = false;
            int highOfLetva = 0;

            while(jumpHigh<desiredHigh)
            {
                for (highOfLetva=desiredHigh - 30 ; highOfLetva <desiredHigh+2; highOfLetva+=5)
                {
                    jumpHigh=int.Parse(Console.ReadLine()) ;
                    jumps++;
                    int failedJumps = 0;

                    if(jumpHigh<highOfLetva) 
                    {
                        failedJumps++;
                        if(failedJumps==3)
                        {   
                            isFailed = true;
                            break;
                        }
                    }
                    else
                    {
                        failedJumps = 0;
                     }
                 
                    
                }
                if (isFailed)
                {
                    break;
                }

            }
            if (isFailed)
            {
                Console.WriteLine($"T{highOfLetva}");
            }
            else if (jumpHigh > desiredHigh)
            {
                Console.WriteLine($"T{highOfLetva}");
            }
        }
    }
}
