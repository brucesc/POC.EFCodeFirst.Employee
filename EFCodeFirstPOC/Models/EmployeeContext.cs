using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstPOC.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
