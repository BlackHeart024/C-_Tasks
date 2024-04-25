using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace TestApi
{
    public class StudDbContext : DbContext
    {
        public DbSet<Student> Student { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Model = CS103-PC; Initial Catalog = StudDb; Integrated Security = True; TrustServerCertificate = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Student>()
                .ToTable("Student","dbo")
                .HasKey(x => x.Stud_Id);
        }
    }
}