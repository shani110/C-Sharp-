using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.com
{
    public class genrics
    {
        //public static void show(int[] a) 
        //{

        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        Console.WriteLine(a[i]);
        //    }
        
        //}

        //public static void show(string[] a)
        //{

        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        Console.WriteLine(a[i]);
        //    }

        //}

        // using generics method 
        public static void show <G>(G[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }


    }
}
