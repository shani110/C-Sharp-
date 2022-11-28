using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace param.com
{
    internal class work
    {
        public void add(params int[] nums )
        {
            int sum = 0;
            foreach (int item in nums)
            {
                sum = sum + item;
            }
            Console.WriteLine(" result of entered numbers is " + sum);
        }
        public void add2(params string[] s_name) 
        {
            string[] s = s_name;
            Console.WriteLine("names of students are");
            for (int i = 0; i < s_name.Length; i++) 
            {

                Console.WriteLine(s[i]);
            
            }


        }
    }
}
