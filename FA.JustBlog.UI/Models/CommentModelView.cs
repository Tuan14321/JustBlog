namespace FA.JustBlog.UI.Models
{
    public class CommentModelView
    {
        public int CommentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PostId { get; set; }
        public string CommentHeader { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }
    }
}
