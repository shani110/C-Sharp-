using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_solution
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; } // this show that grade has one to many relation with student 

    }
}
