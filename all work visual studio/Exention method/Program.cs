using System;

namespace Exention_method
{
    static class objClass
    {


        public static void fun3(this Program p)
        {


            Console.WriteLine("this is third funciton");

        }

    }


    class Program
    {
        public void fun() 
        {

            Console.WriteLine("this is first funciton");
        
        }
        public void fun1() 
        {
            Console.WriteLine("This is second function");
        
        }
       

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.fun3();

        }
    }
}
