using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingProject.module
{
    public class Order
    {
        public int Id { get; set; }
        public int orderAmount { get; set; }

       
        public Customer customer { get; set; }

        public Product product { get; set; }

    }
}
