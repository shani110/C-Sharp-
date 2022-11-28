using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace static_class_and_static_method.com
{
    static class Show
    {
        public static int id;
        public static string name;
        public static string description;

         static Show() 
        {
            id = 1;
            name = "books";
            description = "this book is imported from ucrain";
        
        }

        public static void getData() 
        {

            Console.WriteLine("id  is : {0} name of book is : {1}  : {2}",id,name,description);
        
        }
        public static int getAge(int age) 
        {
            return age;
        
        }



    }
}
