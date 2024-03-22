
using SQLitePCL;

namespace BookLibraryProject.Models
{
    public class EFBookRepository : IBookRepository
    {

        private BookLibraryContext _context;

        public EFBookRepository(BookLibraryContext temp)
        {
            _context = temp;
        }
        public IQueryable<Project> Books => _context.Books;
    }
}
