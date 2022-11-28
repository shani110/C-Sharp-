using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace delegates.com
{
    // generic type delegate 

    public delegate void add<t>(t name, t value);

    internal class example2
    {
        public static void greet(string msg) 
        {
            Console.WriteLine("triying so. class 2nd is called "+msg);
        
        }
        public static void shani(string name, string value)
        {

            Console.WriteLine("your good name is " + name +" your examination board is "+value);


        }

    }
}
