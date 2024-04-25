using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework
{
    public class DemoContextDb : DbContext
    {
        public DbSet<EmployeeModel> Employee {get; set;}
        public DbSet<DepartmentModel> Department {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = CS103-PC; Initial Catalog = EmployeeDb; Integrated Security = True; TrustServerCertificate = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<EmployeeModel>()
                .ToTable("Employee","dbo")
                .HasKey(x => x.Emp_Id);

            modelBuilder.Entity<DepartmentModel>()
                .ToTable("Department","dbo")
                .HasKey(x => x.Dept_Id);

            modelBuilder.Entity<EmployeeModel>()
                .HasOne(x=>x.department)
                .WithMany(x=>x.Employees).HasForeignKey(x=>x.DeptId);
        }
    }
}