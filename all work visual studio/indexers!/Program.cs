using System;

namespace indexers_
{
    class Program
    {
        class person 
        {

            private int age;
            int[] arr = new int[4];
            public int this[int index]
            {

                set
                {
                    if (index >= 0 && index < arr.Length) { 

                        if (value > 0)
                        {

                            arr[index] = value;
                        }
                        else
                        {
                            Console.WriteLine("age can't be zero or null");
                        }
                }
                    else

                    {
                        Console.WriteLine("invalid index");

                    }
                }
               
                get {

                    return arr[index];
                
                }
            }
        
        
        }

        static void Main(string[] args)
        {
        }
    }
}
