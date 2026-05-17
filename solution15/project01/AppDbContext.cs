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
    public DbSet<students> Student { get; set; }
        public DbSet<Courses> Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Company02DB ; Trusted_Connection=True ; TrustServerCertificate=True;");
        }


    }
}
