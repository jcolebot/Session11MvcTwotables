using Microsoft.EntityFrameworkCore;
using CartoonDB.Models;

namespace CartoonDB.Data
{
    public class CartoonDbContext : DbContext
    {
        public CartoonDbContext(DbContextOptions<CartoonDbContext> options) : base(options)
        {
        }

        public DbSet<Show> Shows {get;set;}
        public DbSet<Character> Characters {get;set;}
    }
}