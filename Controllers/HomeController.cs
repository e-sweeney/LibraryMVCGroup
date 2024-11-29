using System.Diagnostics;
using LibraryMVCGroup.DBAccess;
using LibraryMVCGroup.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryMVCGroup.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryDBContext _dbContext;

        public HomeController(LibraryDBContext libraryDBContext)
        {
            _dbContext = libraryDBContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
