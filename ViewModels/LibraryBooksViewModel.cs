namespace LibraryMVCGroup.ViewModels
{
    
    public class LibraryBooksViewModel
    {
        public string LibraryName { get; set; } = string.Empty;
        public IEnumerable<string> BookTitles { get; set; } = new List<string>();
    }
}
