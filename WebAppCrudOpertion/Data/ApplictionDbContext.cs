using Microsoft.EntityFrameworkCore;
using WebAppCrudOpertion.Models;

namespace WebAppCrudOpertion.Data
{
    public class ApplictionDbContext :DbContext
    {
        public ApplictionDbContext(DbContextOptions<ApplictionDbContext> options):base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet <Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
