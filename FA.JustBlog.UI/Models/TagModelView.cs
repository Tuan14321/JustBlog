namespace FA.JustBlog.UI.Models
{
    public class TagModelView
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string? UrlSlug { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
    }
}
