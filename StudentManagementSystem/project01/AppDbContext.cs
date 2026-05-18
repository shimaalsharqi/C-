using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=StudentManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Student> Student01 { get; set; }
        public DbSet<Department> Department01 { get; set; }
        public DbSet<Course> Course01 { get; set; }
      

    }
}
