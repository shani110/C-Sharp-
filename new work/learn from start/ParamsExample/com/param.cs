using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsExample.com
{
    internal class param
    {
        public void add(params int[] nums)
        {
            int sum = 0;
            foreach (int item in nums)
            {
                sum = sum + item;
            }
            Console.WriteLine(" result of entered numbers is " + sum);
        }
}
