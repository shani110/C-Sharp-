using System;

namespace methodHiding
{
    class Program
    {
        class parent
        {

            public void show()
            {
                Console.WriteLine("hello mr essa, you are welcome here, this is parent's method");
            }


        }
        class child : parent
        {
            public new void show()
            {


                Console.WriteLine("hello mr essa, this is child mehtod");

            }


        }

        static void Main(string[] args)
        {
            // hiding parent method. 
            //Console.WriteLine("i am going to show parent method by using technique first");

            //var obj = new child();
            //obj.show();

            //calling parent method

            //((parent)obj).show();
            //child obj1 = new child();
            //obj1.show();
            //Console.WriteLine(" -------------- showing parents methos--------------");
            //((parent)obj1).show();
        
            

        }
    }
}