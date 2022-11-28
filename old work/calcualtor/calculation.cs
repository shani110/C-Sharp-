using System;
using System.Collections.Generic;
using System.Text;

namespace calcualtor
{
    class calculation
    {
        int a;
        int b;
        int result;

        public void add(int a, int b) 
        {
            result = this.a + this.b;
            Console.WriteLine(result);
        }
        public void sub(int a, int b)
        {
            result = a-b;
            Console.WriteLine(result);
        }
        public void div(int a, int b)
        {
            result = a / b;
            Console.WriteLine(result);
        }
        public void mult(int a, int b)
        {
            result = a * b;
            Console.WriteLine(result);
        }
    }
}
