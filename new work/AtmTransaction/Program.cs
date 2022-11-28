using System;

namespace AtmTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            int netAmount = 6000;
            Console.WriteLine("Enter amount to widraw");
            int amount = int.Parse(Console.ReadLine());

            try
            {
                if (amount > netAmount)
                {
                    throw new Exception("Balance insufficiant");



                }
                else
                {
                    netAmount = netAmount - amount;
                    Console.WriteLine("widrawing amount ");
                    Console.WriteLine("transaction completer");
                    Console.WriteLine("your remaining balance is " + netAmount);

                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            
            }


        }
    }
}
