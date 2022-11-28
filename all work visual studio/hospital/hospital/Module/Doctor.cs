using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Module
{
    public class Doctor
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public int age { get; set; }    
        public string hName { get; set; }
    }
}
