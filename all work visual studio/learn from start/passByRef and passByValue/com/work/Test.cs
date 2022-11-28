using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passByRef_and_passByValue.com.work
{
    internal class Test
    {
        public void passByValue(int a) 
        {

            a = a + 20;
            Console.WriteLine("your value is"+a);
        
        }

        public void passByRef(ref int b) 
        {

            b = b + 20;
            Console.WriteLine("value of b in method is "+ b);
        }

    }
}
