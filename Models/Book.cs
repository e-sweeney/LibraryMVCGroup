namespace LibraryMVCGroup.Models
{
    public class Book

    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int PublishedYear { get; set; }
        public Boolean IsAvailable { get; set; } = true;

        public int LibraryID { get; set; }
        public Library Library { get; set; } = new Library();
    }
}
