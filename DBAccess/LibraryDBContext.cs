using LibraryMVCGroup.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LibraryMVCGroup.DBAccess
{
    public class LibraryDBContext :DbContext

    {
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options): base(options)
        {

            
        }

        public DbSet<Library> Libraries { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
    }



   
}
