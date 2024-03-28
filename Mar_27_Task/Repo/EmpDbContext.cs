using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

public class EmpDbContext : DbContext
{
    public Dbset<Department> Departments { get; set; }
    public Dbset<Employee>? Employees { get; set; }

    protected override void OnConfuring(EmpDbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Datasource=CS103-PC, Initial Catalogue=EmpDb, Integrated Security=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}