using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.com
{
    static class new_child
    {
        public static void fun3(this old p) 
        {

            Console.WriteLine("this is child class ");
        
        }
        public static void fun4(this old o, int id, string name) 
        {

            Console.WriteLine("hello {0} how are you, your id is {1} ",name,id);

        }

    }
}
