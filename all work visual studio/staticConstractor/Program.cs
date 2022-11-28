using System;

namespace staticConstractor
{

    class student 
    {
        public string name;

        public student(string name) {

            this.name = name;

        }


        public void getName() 
        {
            Console.WriteLine("you entered the name "+this.name);
        
        }
        public student(student s) 
        {
            this.name = s.name;
           
        
        }

    
    }


    class Program
    {
        static void Main(string[] args)
        {
            student obj = new student("ali");
            obj.getName();
            student obj1 = new student(obj);
            obj.getName();


            //student obj = new student();
            //student obji = new student();

        }
    }
}
