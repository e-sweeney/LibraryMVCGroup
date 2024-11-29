using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryMVCGroup.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public DateTime MembershipDate { get; set; } = DateTime.Now;
       
        public int LibraryID { get; set; }
        public Library Library { get; set; } = new Library();
    }
}
