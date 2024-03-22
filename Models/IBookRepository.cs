namespace BookLibraryProject.Models
{
    public interface IBookRepository
    {
        public IQueryable<Project> Books { get; }
    }
}
