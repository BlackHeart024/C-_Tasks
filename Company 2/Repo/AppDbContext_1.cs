using System.Reflection;
using Microsoft.EntityFrameworkCore;
namespace Company{
    public class AppDbContext : DbContext{
        
        public DbSet<Department> Department { get; set; }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ABHISHEK\\SQLEXPRESS; Initial Catalog=CompDb; Integrated Security=True; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Department>()
                .ToTable("Department","dbo")
                .HasKey(x => x.Dept_id);

            modelBuilder.Entity<Employee>()
                .ToTable("Employee","dbo")
                .HasKey(x => x.Emp_id);   

            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Department)
                .WithMany(x => x.Employee)
                .HasForeignKey(x => x.Emp_department_id);
        }
    }
}