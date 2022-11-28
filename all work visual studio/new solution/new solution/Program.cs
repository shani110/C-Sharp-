// See https://aka.ms/new-console-template for more information
//using new_solution;



using Microsoft.EntityFrameworkCore;
using new_solution;

using (var context = new Context())
{
    //var std = new Student()
    //{
    //    Name = "isa"

    //};
    //var std1 = new Student()
    //{
    //    Name = "alam"


    //};
    //var std2 = new Student()
    //{
    //    Name = "sheraz"


    //};


    //var std = new Student()
    //{
    //    Name = "kamal",

    //};
    var std1 = context.Students.First<Student>();
    std1.Name = "na maloom afrad";
    
    context.Students.Remove(std1);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
    context.SaveChanges();

}


