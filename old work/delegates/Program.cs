using System;

namespace delegates
{
    public delegate void n(int a);
    public delegate void area(int lent, int width);

    class Program
    {


        static void Main(string[] args)
        {
            n obj = delegate (int a) {
                a += 10;
                Console.WriteLine(" value of a = "+a);

            };
            obj.Invoke(23);
            area obj1 = delegate (int a,int b) 
            {
                int c = a * b;
                Console.WriteLine("square is "+c);
            
            };
            obj1.Invoke(12,2);
        }
    }
}