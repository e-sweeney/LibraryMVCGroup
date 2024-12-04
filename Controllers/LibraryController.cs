using LibraryMVCGroup.DBAccess;
using LibraryMVCGroup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

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

        public IActionResult CountsPerLibrary(int id)
        {
            var libraryCount = new LibraryCountViewModel();
            libraryCount.LibraryName = _dbContext.Libraries.Find(id).Name;
            libraryCount.memberCount = _dbContext.Members.Where(member => member.LibraryID == id).Count();
            libraryCount.bookCount = _dbContext.Books.Where(book => book.LibraryID == id).Count();

            return View(libraryCount);
        }



    }
}

