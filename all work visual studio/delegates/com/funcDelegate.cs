using System;
using System.Collections.Generic;
using System.Text;

namespace delegates.com
{
    // take one input and out perameter 
    public delegate TResult Func<in T, out TResult>(T arg);

    public delegate void age(int a);

    // using predicate delegate 
    public delegate bool pri<in T>(T obj);

    internal class funcDelegate
    {
        public static int sum(int x, int y)
        {
            return x + y;
        }

        public static void a(int a) 
        {

            Console.WriteLine(" your age is "+a);
        }
       public static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

    }
}
