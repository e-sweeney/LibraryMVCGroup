﻿using LibraryMVCGroup.DBAccess;
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
            var availablebooks = _dbContext.Books.Where(b => b.IsAvailable == true & b != null).Include(b => b.Library).GroupBy(b => b.Library).Select(g => new LibraryBooksViewModel
            {
                LibraryName = g.Key.Name,
                BookTitles = g.Select(b => b.Title)


            });
            return View(availablebooks);


            
        }

        
    }
}
