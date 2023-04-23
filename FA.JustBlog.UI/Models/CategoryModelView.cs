namespace FA.JustBlog.UI.Models
{
    public class CategoryModelView
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? UrlSlug { get; set; }
        public string Description { get; set; }
    }
}
