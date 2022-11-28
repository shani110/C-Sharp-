using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingProject.module;

namespace WorkingProject.context
{
    internal class DataContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }

        public DbSet<Product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SPLHRLAP-1084;Database=shopDb1;Trusted_Connection=True; ");
        }



    }
}
