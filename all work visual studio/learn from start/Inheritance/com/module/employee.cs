using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.com.module
{
    public class employee : person
    {
        public int salary;

        public void setfields(int id, int age, string name, int salary) 
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }


        public void show()
        {

            Console.WriteLine($"name {name} id {id} age {age} salary {salary}");
        }
    }
}
