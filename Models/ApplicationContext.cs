using Microsoft.EntityFrameworkCore;

namespace Wave.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated(); // Создаем бд при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {Id = 1, Login = "mama", Password = "kuku", UserName = "First"}
            );
        }
    }
}
