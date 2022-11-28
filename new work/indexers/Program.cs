using System;

namespace indexers
{
    class store 
    {

        private int[] things = new int[4];

        public int this[int index]
        {
            set { /* set the specified index to value here */

                if (index >= 0 && index < things.Length)
                {

                    if (value > 0)
                    {
                        things[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("items can't be null and negative");

                    }
                }
                else 
                {

                    Console.WriteLine("invaled index");
                
                }

            }

            get { /* return the specified index here */
                return things[index];
            }
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            store s = new store();
            s[5] = 12;
            Console.WriteLine(s[1]);

        }
    }
}
