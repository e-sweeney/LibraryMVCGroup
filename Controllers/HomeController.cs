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

        public IActionResult Index()
        {
           
            return View();
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
