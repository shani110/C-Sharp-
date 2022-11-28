using System;

namespace staticClass
{
    static class kiu 
    {

        static string name = " karakoram international university";
        static string dname = "Computer science";
        static int fees = 34000;

        public static void getInfo() 
        {

            Console.WriteLine("Uni Name: "+name);
            Console.WriteLine("Department Name "+dname);
            Console.WriteLine(" Fees of computer science in which you are going to enrol "+fees);
        
        
        }

        public static void disFees() 
        {

            Console.WriteLine("your can get discount of "+ fees/10);
            Console.WriteLine(" you have to pay "+(fees -(fees/10)));
        
        }

    
    }



    class Program
    {
        static void Main(string[] args)
        {

            kiu.getInfo();
            Console.WriteLine("----------------------------");
            kiu.disFees();

        }
    }
}
