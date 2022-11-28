using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfProject.Module
{
    public class data : DbContext
    {
        public DbSet<Employe> Employes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SPLHRLAP-1084;Database=LearningManagementSystem;Trusted_Connection=True;");
        }

    }
}
