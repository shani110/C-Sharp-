using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach.Learning_Management_System.Module
{
    public class Teacher
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public int salary  { get; set; }



    }
}
