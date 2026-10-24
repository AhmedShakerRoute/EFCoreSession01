using EFCoreSession01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession01.DbContexts
{
    internal class MyCompanyDbContext : DbContext
    {
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.;Database=MyCompanyDb;Trusted_Connection=True;TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
