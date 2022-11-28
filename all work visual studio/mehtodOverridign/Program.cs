using System;

namespace mehtodOverridign
{
    class person 
    {
        public virtual void show()
        {
            Console.WriteLine(" this is parent class");
        }
    }
    class student : person 
    {

        public override void show() 
        
        {
          
            Console.WriteLine("this is child method");
        
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            student obj = new student();
            obj.show();

        }
    }
}
