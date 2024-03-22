using Microsoft.AspNetCore.Mvc;
using Mission11_Purnell.Controllers.ViewModels;
using Mission11_Purnell.Models;
using System.Diagnostics;

namespace Mission11_Purnell.Controllers
{
    public class HomeController : Controller
    {
        // follow repository pattern
        private IBookstoreRepository _repo;

        public HomeController(IBookstoreRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            // pass book data into the view
            var bookvar = new BookListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(bookvar);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
