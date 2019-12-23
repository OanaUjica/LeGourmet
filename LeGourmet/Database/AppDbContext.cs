using LeGourmet.Models;
using Microsoft.EntityFrameworkCore;


namespace LeGourmet.Database
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
