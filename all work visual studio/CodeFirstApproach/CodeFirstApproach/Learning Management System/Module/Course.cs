using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach.Learning_Management_System.Module
{
    public class Course
    {
        [Key]
        public int course_id { get; set; }
        public string course_name { get; set; }

    }
}
