using LibraryMVCGroup.DBAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryMVCGroup.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryDBContext _dbContext;

        public BooksController(LibraryDBContext libraryDBContext)
        {
            _dbContext = libraryDBContext;
        }
        public IActionResult Index()
        {
            var availableBooks = _dbContext.Books.Where(b => b.IsAvailable == true).Include(b => b.Library).GroupBy(b => b.Library).Select(g => new
            {
                Library = g.Key, // The Library entity
                Books = g.ToList() // The list of books in this library
            });
    
            return View(availableBooks);
        }

        //left off here - going to group by Library and sjhow all books available.
    }
}
