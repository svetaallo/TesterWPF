using Microsoft.EntityFrameworkCore;

namespace TesterWPF.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Card> Cards => Set<Card>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}