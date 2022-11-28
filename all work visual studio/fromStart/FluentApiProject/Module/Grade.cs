using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApiProject.Module
{
    public class Grade
    {

        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        // creating one to one relationship with grade

    }
}
