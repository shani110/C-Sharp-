using System;

namespace testing
{


    class person 
    {
    
    private static string  stname ;

        public static string _stname 
        {
            set 
            {
                stname = value;
            }


            get {

                return stname;
            
            } }


    }


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Student name is "+person._stname);

        }
    }
}