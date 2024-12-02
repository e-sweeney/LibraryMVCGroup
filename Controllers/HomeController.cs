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
            //Changes to MVC CRud
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
