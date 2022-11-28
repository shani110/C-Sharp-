using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.com
{
    public delegate void calculation(int a, int b);

    internal class Delegates
    {
        public static void add(int a, int b) 
        {
            int c = a + b;
            Console.WriteLine("Result is "+c);
        }

    }
}
