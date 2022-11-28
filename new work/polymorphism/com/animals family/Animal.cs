using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism.com.animals_family
{
     class Animal
    {
        public string name;
        public int age;
        public string color;

        public void setFields(string n, int a, string c) 
        {
            this.name = n;
            this.age = a;   
            this.color = c;
        }
         public void show() 
        {

            Console.WriteLine("this is parent class");
        
        }

        public virtual void sound(string s) 
        {
            
            Console.WriteLine("parent animal makes sound ");
        
        }


    }
}
