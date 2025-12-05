using CRUD1.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD1.DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
