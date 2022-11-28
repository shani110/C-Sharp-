using System;

namespace Program__
{

    class Employee 
    {
        public string age;

    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.age = "ali";
            Employee e1 = e;
            Employee e2 = e1;
            e.age = "esa";
            Console.WriteLine(e.age);
            Console.WriteLine(e1.age);

            Console.ReadLine();
        }
    }
}
