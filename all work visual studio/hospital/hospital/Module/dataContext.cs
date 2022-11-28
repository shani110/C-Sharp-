using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Module
{
    public class dataContext : DbContext
    {
        public DbSet<Doctor> doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SPLHRLAP-1084;Database=hospitalDb;Trusted_Connection=True;");
        }


    }


}
