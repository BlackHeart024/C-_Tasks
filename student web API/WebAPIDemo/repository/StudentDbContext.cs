using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Properties;

namespace WebAPIDemo.repository
{
    public class StudentDbContext: DbContext
    {
        public DbSet<Student> students{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = CS103-PC; Initial Catalog = StudDb; Integrated Security = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Student>()
                .ToTable("Student", "dbo")
                .HasKey(x => x.Stud_Id);
        }
    }
}