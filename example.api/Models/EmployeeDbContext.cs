using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example.api.Models
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options)
        {

        }

        public DbSet<Student> Student { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<Address> Address { get; set; }

    }
}
