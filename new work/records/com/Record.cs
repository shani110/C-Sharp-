using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace records.com
{
    public record Record(string name, int age);
    public record Record1(string fname, string lname) 
    {
        public string fname { get; init; } = fname;

        //working with methods in c#
        private string name = fname;

        public string firstname
        {
            get { return firstname.Substring(0, 1); }
            init { }
        }
        public string fullName { get => $"{fname} {lname}"; }

        public string sayhello() 
        {
        return $"Hello {fullName}";
        }

    }

   
}
