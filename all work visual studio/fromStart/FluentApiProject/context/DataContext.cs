using FluentApiProject.Module;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApiProject.context
{
    public class DataContext :DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SPLHRLAP-1084;Database=newDatabase;Trusted_Connection=True; ");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Student>().Property(s=>s.studentId).HasColumnName("Registration_number").IsRequired();

            //modelBuilder.Entity<Student>()
            //    .HasOne<Grade>(s => s.Grade).WithMany(g => g.Students).HasForeignKey(h => h.CurrentGradeId); // ONE TO MANY RELATIONSHIP

            // THIS WILL DELETE CHILD ROW IF WE DELETER PARENT ROW
            //        modelBuilder.Entity<Grade>()
            //.HasMany<Student>(g => g.Students)
            //.WithOne(s => s.Grade)
            //.HasForeignKey(s => s.CurrentGradeId)
            //.OnDelete(DeleteBehavior.Cascade);

            // creating one to one relationship with student and grade
        


        }
    }
}
