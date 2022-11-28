using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 18)
            {

                Console.WriteLine("you are eligible to vote");

            }
            else
            {
                throw new Exception(" your are teen aged.");
            
            }
        
        }
    }
}
