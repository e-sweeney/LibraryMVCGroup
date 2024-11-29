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
            var availableBooks =  _dbContext.Books.Where(b => b.IsAvailable).ToList();
            return View(availableBooks);
        }

        
    }
}
