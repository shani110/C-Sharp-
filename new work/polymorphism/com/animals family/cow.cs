using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism.com.animals_family
{
    internal class cow : Animal 
    {
        public string amountOfMilk;
        public string shape;
        public string t_cow;

        public void setCow(string amilk,  string type) 
        {
        this.amountOfMilk = amilk; 
        this.t_cow = type;

        } 
     
        public   void  show(string shp)
        {
            this.shape = shp;
            Console.WriteLine("Name of animal = "+ name);
            Console.WriteLine("age of animal = " + age);
            Console.WriteLine("color of animal = " + color);
            Console.WriteLine("Amount of milk " + amountOfMilk);
            Console.WriteLine("type of cow = " + t_cow);

        }

    }
}
