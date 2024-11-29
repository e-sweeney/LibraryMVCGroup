using LibraryMVCGroup.DBAccess;
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

        public IActionResult CountMembersPerLibrary()
        {
            var countMembersPerLibrary = _dbContext.Members.GroupBy(l => l.Library.Name).Select(g => new { LibraryName = g.Key, Members = g.Count() });

            ViewBag.countMembersPerLibrary = countMembersPerLibrary;


            return View();
        }
    }
}
