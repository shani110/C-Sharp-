using System;

namespace practise
{
     class animal 
    {
        public static virtual void sound() 
        {
            Console.WriteLine("Animal produces sounds ");
        
        }
    }
 class cow : animal
    {// now its time to learn method overriding method 
        public override void sound() 
        {

            Console.WriteLine(" cow produce sound boooo boooo");
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            animal obj = new animal();
            obj.sound();
            cow ob1 = new cow();
            ob1.sound();
        }
    }
}
