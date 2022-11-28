using System;

namespace privateConstructor
{
    class Program
    {
        class test
        {
          


            private test()
            {


            }
            public static void add(int a, int b) 
            {
                Console.WriteLine("result = "+(a+b));
            
            }
        
        }



        static void Main(string[] args)
        {
            test.add(2, 4);
        }
    }
}
