using System;

namespace myCosolve
{
  abstract class person 
    {
       public  int age;
     public  string name;
        public abstract void show();
    
    
    }

    class student : person
    {
      public  int rollNO;
        public override void show()
        {
            Console.WriteLine(" Name of the student is "+this.name);
            Console.WriteLine("student age is "+this.age);
            Console.WriteLine("Registration of student is "+this.rollNO);
        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            student obj = new student();
            obj.name = "Muhammad isa ";
            obj.age = 23;
            obj.rollNO = 5532;
            obj.show();
         }
    }
}
