using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism.com.animals_family
{
    internal class bird :Animal
    {
        public string fly 
        {
            get; set; 
        }
        public void show() 
        {
            Console.WriteLine("name of bird "+name);
            Console.WriteLine("age of the bird "+age);
            Console.WriteLine( "color of the bird "+color);
            Console.WriteLine(" bird can fly "+fly);
        
        }
        public override void sound(string fly) 
        { 
            this.fly = fly; 
            Console.WriteLine("this is bird class and bird can fly with "+fly);
           this.show();
            
        }

    }
}
