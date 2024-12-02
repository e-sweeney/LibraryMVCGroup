using System.Diagnostics;
using LibraryMVCGroup.DBAccess;
using LibraryMVCGroup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryMVCGroup.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryDBContext _dbContext;

        public HomeController(LibraryDBContext libraryDBContext)
        {
            _dbContext = libraryDBContext;
        }

        public IActionResult Index(string searchString)
        {
            IEnumerable<Book> bookList = _dbContext.Books.Select(p => p);
            if (!string.IsNullOrEmpty(searchString))
            {
                bookList = _dbContext.Books.Where(s => s.Author.Contains(searchString) && s.Author!=null);
            }
            return View(bookList);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
