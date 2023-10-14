using System;
using ExamASP.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExamASP.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
