
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext {

        // public MyDbContext() {} // Uncomment and this work
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public MyDbContext() {}

        public DbSet<Entity> Entities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=my.db");
            }
        }
}