using System;
using System.Collections.Generic;
using System.Text;

namespace delegates.com
{
    //public delegate void greet(string msg);

    public delegate void show(string name, int reg);
    public delegate void cal(string msg);

    internal class example
    {
        //   public static void hello(string m)
        //{

        //    Console.WriteLine(m);
        //}
        //public static void esa(string name, int reg)
        //{

        //    Console.WriteLine("hello " + name + " your registration number is " + reg);

        //}
        public static void greet(string msg) 
        {

            Console.WriteLine("try to work hard. class ist called "+msg);
        }

        


    }
}
