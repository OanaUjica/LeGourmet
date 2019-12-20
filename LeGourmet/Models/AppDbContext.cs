using Microsoft.EntityFrameworkCore;


namespace LeGourmet.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
