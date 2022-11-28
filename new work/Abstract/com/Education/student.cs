using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.com.Education
{
    internal class student : person
    {
        
        public override void show() 
        {
            Console.WriteLine("this is student and here are his some details.");
        }
        public override void showDetails() 
        {
            Console.WriteLine("name of student is "+name);
            Console.WriteLine("age of student is "+age);
        }
    }
}
