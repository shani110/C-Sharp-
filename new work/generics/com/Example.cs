using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace generics.com
{
    public class Example <G>
    {
        G a;

        // set value throug constructor 

        //public Example(G a) 
        //{
        //    this.a = a;
        //}
        //public void geta() 
        //{

        //    Console.WriteLine("value of a is "+ a);
        //}

        // set value throgh properties 

        public G show 
        {
            set
            {
               this.a = value;
            }

            get 
            {
                return this.a;
            
            }
        
        
        }

    }
}
