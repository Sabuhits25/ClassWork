using ClassWork.Models;
using ClassWork.Models.ConsoleAppWithEFCore.Models;
using Microsoft.EntityFrameworkCore;


namespace ConsoleAppWithEFCore.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MYNOTEBOOK-99\SQLEXPRESS;Database=Market;Trusted_Connection=True;");
        }
    }                       
}
