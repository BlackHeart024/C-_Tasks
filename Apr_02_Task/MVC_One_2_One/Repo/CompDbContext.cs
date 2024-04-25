using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Company
{
    public class CompDbContext : DbContext
    {
        public DbSet<AddressMaster> AddressMaster { get; set; }
        public DbSet<EmployeeMaster> EmployeeMaster { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CS103-PC; Initial Catalog=CompOne2OneDb; Integrated Security=True; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<AddressMaster>()
                .ToTable("AddressMaster", "dbo")
                .HasKey(x => x.Address_id);

            modelBuilder.Entity<EmployeeMaster>()
                .ToTable("EmployeeMaster", "dbo")
                .HasKey(x => x.Employee_id);

            modelBuilder.Entity<EmployeeMaster>()
                .HasOne(x => x.AddressMaster)
                .WithOne(x => x.EmployeeMaster)
                .HasForeignKey<EmployeeMaster>(x => x.Employee_address_id);
        }
    }
}