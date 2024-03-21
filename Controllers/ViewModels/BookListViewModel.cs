using Mission11_Purnell.Models;

namespace Mission11_Purnell.Controllers.ViewModels
{
    public class BookListViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }   
}
