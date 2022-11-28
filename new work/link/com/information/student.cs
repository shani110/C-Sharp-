using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace link.com.information
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }

    internal class student
    {
        public int Id { get;  }
        public string Name { get;  }
        public int Age { get;  }
        public student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

    
    }
}
