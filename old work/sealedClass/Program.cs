using System;

namespace sealedClass
{
    public delegate void calculation(int a, int b);

        class Program
        {
        public static void add(int a, int b) 
        {

            int c = a + b;
            Console.WriteLine( "result is "+c);
        
        }
        public static void sub(int a, int b)
        {

            int c = a - b;
            Console.WriteLine("substration of the numbers are  " + c);

        }
        public static void mult(int a, int b)
        {

            int c = a * b;
            Console.WriteLine("multiplication is " + c);


        }
        public static void div(int a, int b)
        {

            int c = a / b;
            Console.WriteLine("division of two number  is " + c);

        }

        static void Main(string[] args)
            {
            calculation obj = new calculation(Program.add);
            obj += sub;
            obj += div;
            obj += mult;

            obj.Invoke(200, 100);
               
            }
        }
    }
