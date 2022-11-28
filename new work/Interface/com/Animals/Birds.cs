using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.com.Animals
{
    internal class Birds : Ianimal
    {
        public void walk() 
        {
            Console.WriteLine("birds usually fly ");
        
        }
        public void eat() 
        {
            Console.WriteLine(" bird eat small insects ");
        
        }
    }
}
