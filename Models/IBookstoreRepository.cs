namespace Mission11_Purnell.Models
{
    // follow the repository pattern
    public interface IBookstoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
