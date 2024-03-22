namespace BookLibraryProject.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IQueryable<Project> Books { get; set; }

        public Paginationinfo Paginationinfo { get; set; } = new Paginationinfo();
    }
}
