namespace FA.JustBlog.Core.Models
{
    public class PostTagMap
    {
        public int PostId { get; set; }
        public Posts Post { get; set; }

        public int TagId { get; set; }
        public Tags Tag { get; set; }
    }
}
