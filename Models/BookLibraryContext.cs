using Microsoft.EntityFrameworkCore;

namespace BookLibraryProject.Models
{
    public class BookLibraryContext : DbContext
    {
        public BookLibraryContext (DbContextOptions<BookLibraryContext> options) : base(options) { }

        public DbSet<Project> Books {  get; set; }
    }
}
