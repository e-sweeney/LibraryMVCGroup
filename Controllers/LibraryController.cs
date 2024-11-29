using LibraryMVCGroup.DBAccess;
using Microsoft.AspNetCore.Mvc;

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
    }
}
