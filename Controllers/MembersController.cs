using LibraryMVCGroup.DBAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryMVCGroup.Controllers
{
    public class MembersController : Controller
    {
        private readonly LibraryDBContext _dbContext;

        public MembersController(LibraryDBContext libraryDBContext)
        {
            _dbContext = libraryDBContext;
        }
        public IActionResult Index()
        {
            var memberList = _dbContext.Members.Include(m => m.Library).OrderByDescending(m => m.MembershipDate);

            return View(memberList);
        }
    }
}
