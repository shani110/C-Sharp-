using System;

namespace op
{
    class calculation
    {        public string name;
        public static calculation operator +(calculation obj1, calculation obj2)
            {
            calculation obj3 = new calculation();
            obj3.name = obj1.name + obj2.name;
            return obj3;
           }
    }


    class Program
    {
        static void Main(string[] args)
        {
            calculation obj1 = new calculation();
            obj1.name = " muhammad ";

            calculation obj2 = new calculation();
            obj2.name = " isa";

            calculation obj3 = new calculation();
            obj3.name = obj1.name + obj2.name;
            Console.WriteLine(obj3.name );
        }
    }
}
