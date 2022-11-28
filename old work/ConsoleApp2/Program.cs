using System;

namespace ConsoleApp2
{
    class student
    {
        public int age;

        public student(int age) 
        {
            this.age = age;
        
        }
        public int getAge()
        {
            return this.age;
        }

        ~student() 
        {
            Console.WriteLine("Destructor has been invoked.. it will delet obj memory once it has been done. ");

        }
    
    }
   
        

    
    
    class Program
    {
        static void Main(string[] args)
        {
            student obj = new student(34);
            Console.WriteLine(obj.getAge());
            Console.ReadLine();

        }
    }
}
