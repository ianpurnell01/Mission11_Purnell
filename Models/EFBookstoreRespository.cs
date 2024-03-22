
namespace Mission11_Purnell.Models
{
    // inherit from IBookstoreRepository
    public class EFBookstoreRespository: IBookstoreRepository
    {
        private BookstoreContext _context;
        public EFBookstoreRespository(BookstoreContext temp)
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;

    }
}
