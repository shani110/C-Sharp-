using delegates.com;
using System;
using System.Runtime.InteropServices;

namespace delegates
{
    //public delegate void n(int a);
    //public delegate void area(int lent, int width);
    



    class Program
    {


        static void Main(string[] args)
        {
            //n obj = delegate (int a) {
            //    a += 10;
            //    Console.WriteLine(" value of a = "+a);

            //};
            //obj.Invoke(23);
            //area obj1 = delegate (int a,int b) 
            //{
            //    int c = a * b;
            //    Console.WriteLine("square is "+c);

            //};
            //obj1.Invoke(12,2);


            //greet obj = new greet(example.hello);
            //obj.Invoke("hello essa how are you");

            //show obj = new show(example.esa);

            //obj("shani", 32);

            // calling by lambda expression 

            //show obj = (string name , int reg) => example.esa(name, reg);

            //obj("kaamran", 4020);

            //cal obj = new cal(example.greet);

            //obj.Invoke("lail bai");

            //obj = example2.greet;

            //obj.Invoke("shani");

            // calling generic type delegate 

            //add<string> obj = example2.shani;
            //obj.Invoke("Essa", " lAHORE BOARD OF INTERMIDATE EXAMINATION");



            // calling func delegate which has take iput and  output perameter

            //Func<int, int, int> add = funcDelegate.Sum;

            //int result = add(1,2);
            //Console.WriteLine(" answer is "+result);

            //delegate func with  anonymous function

            //printing random nuber between 1 AND 100
            //Func<int> getRandomNumber = delegate ()
            //{
            //    Random rnd = new Random();
            //    return rnd.Next(1, 100);
            //};
            //int number = getRandomNumber();
            //Console.WriteLine("Random number between 1 and 100 is "+number);

            // WITH LAMBDA EXPRESSION 

            //Func<int,int,int> obj = (int a, int b) => (a + b);
            //obj = funcDelegate.sum;
            //int result = obj(12, 32);
            //Console.WriteLine(" result of entered numbers are "+result);

            //Func<int> getrandom = () => new Random().Next(1, 100);

            //int a = getrandom();
            //Console.WriteLine("random number by lambda expression is "+a);

            //Action<int> obj = funcDelegate.a;
            //obj(23);

            //Action<int> obj = (a) => Console.WriteLine("your age is "+a);
            //obj(23);


            // Pridicate delegage returns a boolen value 

            //pri<string> obj = funcDelegate.IsUpperCase;

            //bool result = obj("HELLO");
            //Console.WriteLine(result);


         
        }
    }
}