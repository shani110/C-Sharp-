using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace structues.com
{
    internal struct myStructure

    {

        // we can do every thing almost every thing as class do .. but we can not do inheritance with structure
        public int a;
        public int b;
        public int age;


        public void add() 
        {
            Console.WriteLine(" answer of a and b is "+(a+b));
        }
        
    }
  
}
