using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApiProject.Module
{
    public class Student
    {
        public int studentId { get; set; }
        public string Name { get; set; }

        public int CurrentGradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
