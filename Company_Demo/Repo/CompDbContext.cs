using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Company_Demo
{
    public class CompDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Data source = CS103-PC; Initial Catalog = CompDb; Integrated Security = True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Employee>()
                .ToTable("Employee", "dbo")
                .HasKey(x => x.Emp_id);
        }
    }
}