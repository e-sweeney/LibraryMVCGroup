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
                  
             return View();
        }



    }
}
