using Microsoft.EntityFrameworkCore;

namespace Company.Models
{
    public class DbApp : DbContext
    {
        public DbApp() : base()
        {
            
        }
        public DbApp(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Department>? Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=CompanyMVC;Integrated Security=True;TrustServerCertificate=True");

        }
    }
}
