using LibraryMVCGroup.DBAccess;
using LibraryMVCGroup.ViewModels;
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
           
            var availableBooks= _dbContext.Books.Where(b => b.IsAvailable == true & b != null)
                .Include(b => b.Library).GroupBy(b => b.Library).Select(g => new LibraryBooksViewModel
                {
                    LibraryName = g.Key.Name, // The Library entity
                    BookTitles = g.Select(b => b.Title) // The list of book titles in this library
                });
            
            
          

            return View(availableBooks);
        }

        
    }
}
