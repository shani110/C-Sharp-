using System;
using System.Collections.Generic;
namespace collection
{
    class Program
    {
        class student 
        {

            public string name { get; set; }
            public int regNo { get; set; }
            public int age { get; set; }

        }
        static void Main(string[] args)
        {
            student aslam = new student();
            aslam.age = 123;
            aslam.name = " aslam";
            aslam.regNo = 5532;
            student esa = new student();
            esa.age = 23;
            esa.name = " esa";
            esa.regNo = 5532;

            List<student> st = new List<student>();
            st.Add(esa);
            st.Add(aslam);
            foreach (student item in st)
            {
                Console.WriteLine("name of student: {0} \n registration number : {1}\n age of student : {2}",item.name,item.regNo,item.age);
            }

        }

    }
}
