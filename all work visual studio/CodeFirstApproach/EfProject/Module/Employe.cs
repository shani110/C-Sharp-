using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfProject.Module
{
    public class Employe
    {
        [Key]
        public int empId { get; set; }
        public string empName { get; set; }

        public int empAge { get; set; }
        public int empSalary { get; set; }
        
    }
}
