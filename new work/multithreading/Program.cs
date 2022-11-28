 using System;
using System.Threading;
namespace multithreading
{
    class Program
    {
        public static void fun() 
        {
            for (int i = 0; i < 50; i++) 
            {

                Console.WriteLine("function 1 "+i);
            
            }
        
        }
        public static void fun1()
        {
            for (int i = 0; i < 50; i++)
            {

                Console.WriteLine("function 2 " + i);

            }

        }
        public static void fun2()
        {
            for (int i = 0; i < 50; i++)
            {

                Console.WriteLine("function 3 " + i);

            }

        }
        static void Main(string[] args)
        {

            Thread obj = new Thread(fun);
            Thread obj1 = new Thread(fun1);
            Thread obj2 = new Thread(fun2);
            obj.Start();
            obj1.Start();
            obj2.Start();


        }
    }
}
