using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace arrays.com.demo
{
   

    public class rasty
    {
        public int Number { get; }
        public string origin { get; }
        public string Distination { get; }

        public rasty(int Number,String origin, string Destination) 
        {
            this.Number = Number;
            this.origin = origin;  
            this.Distination = Destination;
        }
        public override string ToString() => $"{Number} ka bus {origin} say  {Distination} tak jata ha";
        public static rasty findBusTo(rasty[] rasties, string location)
        {
            // finding route by using arry.find method

            return Array.Find(rasties, ras => ras.origin == location || ras.Distination == location);






            // finding route by using for each loop 

            //foreach (rasty ras in rasties)
            //{
            //    if (ras.origin == location || ras.Distination == location) 
            //    {

            //        return ras;
                
            //    }

            //}

            //return null;
        }

    }
}
