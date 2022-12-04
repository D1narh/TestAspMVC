using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace WebApplication3.Class
{
    public class ApplicationContext :DbContext
    {
        public DbSet<CountDB> Counts => Set<CountDB>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=testApp.db");
        }
    }
}
