using Microsoft.EntityFrameworkCore;

namespace NewWebShopApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
