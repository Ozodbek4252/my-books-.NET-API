using Microsoft.EntityFrameworkCore;
using my_books.Data.Models;

namespace my_books.Data
{
    public class AppDbContext : DbContext
    {
        // this is a bridge wetween Models and database
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        // Models
        public DbSet<Book> Books { get; set; }
    }
}
