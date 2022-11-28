using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        { // divide by zero exception
          //int a =12;
          //int b = 0;
          //try
          //{
          //    int resut = a / b;
          //    Console.WriteLine("result " + resut);

            //}
            //catch(DivideByZeroException ex)
            //{

            //    Console.WriteLine("you can not divede by zero");
            //    Console.WriteLine(ex.Message);
            //}

            // index out of bound exception

            //int[] arr = new int[3];

            //try
            //{
            //    arr[0] = 32;
            //    arr[1] = 23;
            //    arr[2] = 12;
            //    //arr[3] = 23;

            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("your array's index limit exceeded");
            //    Console.WriteLine(ex.Message);
            //}
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            // for null value exception

            //try
            //{
            //    string n = null;

            //    Console.WriteLine("lenth is " + n.Length);

            //}
            //catch (NullReferenceException ex) 
            //{

            //    Console.WriteLine(" there is exception here");
            //    Console.WriteLine(ex.Message);
            //}

            try
            {

                string name = null;
                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException ex) 
            {
                Console.WriteLine("value is null");
                Console.WriteLine(ex.Message);
            
            }
        }
    }
}
