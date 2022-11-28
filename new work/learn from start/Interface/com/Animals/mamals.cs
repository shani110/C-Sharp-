using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.com.Animals
{
    internal class mamals : Ianimal
    {
        public void eat()
        {
            Console.WriteLine("mammals eat grass ");
        }

        public void walk()
        {
            Console.WriteLine("mamals walk by thier legs ");
        }
    }
}
