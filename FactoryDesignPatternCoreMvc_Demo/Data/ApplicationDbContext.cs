using FactoryDesignPatternCoreMvc_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace FactoryDesignPatternCoreMvc_Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
