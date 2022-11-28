// See https://aka.ms/new-onsole-template for more information

using fromStart.Context;
using fromStart.Module;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        //    var context = new SchoolContext();
        //    var studentsWithSameName = context.Students
        //                                      .Where(s => s.Name == GetName())
        //                                      .ToList();
        //}
        //public static string GetName()
        //{
        //    return "Bill";
        //}

        //var context = new SchoolContext();

        //var studentWithGrade = context.Students
        //                           .Where(s => s.Name == "Bill").Include(s => s.Grade).FirstorDefault();


        //var context = new SchoolContext();

        //var studentWithGrade = context.Students
        //                        .FromSql("Select * from Students where Name ='Bill'")
        //                        .Include(s => s.Grade)
        //                        .FirstOrDefault();


    }
}
