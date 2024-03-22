namespace Mission11_Purnell.Controllers.ViewModels
{
    public class PaginationInfo
    {
        // set some useful values
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        //determine number of pages
        public int TotalPages => (int)(Math.Ceiling((decimal) TotalItems / ItemsPerPage));

    }
}
