using LibraryMVCGroup.DBAccess;
using LibraryMVCGroup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryMVCGroup.Controllers
{
    public class LibraryController : Controller
    {
        private readonly LibraryDBContext _dbContext;

        public LibraryController(LibraryDBContext libraryDBContext)
        {
            _dbContext = libraryDBContext;
        }
        public IActionResult Index()
        {

            var libraryList = _dbContext.Libraries; 
            return View(libraryList);
        }

        public IActionResult CountsPerLibrary()
        {
            var countsPerLibrary = _dbContext.Libraries.Select(l => new LibraryCountViewModel

            {
                LibraryName = l.Name,
                memberCount = l.Members.Count(),
                bookCount = l.Books.Count() 
            });
        
            


            return View(countsPerLibrary);
        }



    }
}
