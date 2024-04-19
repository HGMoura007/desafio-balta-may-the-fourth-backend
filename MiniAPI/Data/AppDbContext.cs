using Microsoft.EntityFrameworkCore;

namespace MiniAPI
{
    public class AppDbContext : DbContext
    {
        public DbSet<Film> Filme { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}