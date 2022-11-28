using System;

namespace operatorOverloading
{ class box
    {

        private double lenth;

        public double _lenth
        {
            set
            {
                this.lenth = value;

            }
            get

            {
                return this.lenth;


            }
        }

        public static box operator +(box a, box b)
            
            {
            box bo = new box();
            bo.lenth = a.lenth + b.lenth;
            return bo;
            
            }

    }
    class Program
    {
        static void Main(string[] args)
        {
            box obj = new box();
            box obj1 = new box();
            box obj2 = new box();
            obj._lenth = 12.2;
            obj1._lenth = 32.23;
            obj2 = obj1 + obj;
            Console.WriteLine("total lenth "+obj2._lenth);


        }
    }
}
