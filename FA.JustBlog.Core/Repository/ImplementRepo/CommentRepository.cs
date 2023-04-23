using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repository.GenericRepo;
using FA.JustBlog.Core.Repository.IRespository;

namespace FA.JustBlog.Core.Repository.ImplementRepo
{
    public class CommentRepository : GenericRepository<Comments>, ICommentRepository
    {
        public CommentRepository(JustBlogContext context) : base(context)
        {
        }

        public void AddComment(int postId, string commentName, string commentEmail, string commentTitle, string commentBody)
        {
            var newComment = new Comments
            {
                PostId = postId,
                Name = commentName,
                Email = commentEmail,
                CommentHeader = commentTitle,
                CommentText = commentBody,
                CommentTime = DateTime.Now,
            };

            context.Comments.Add(newComment);
        }

        public IList<Comments> GetCommentsForPost(int postId)
        {
            return context.Comments.Where(c => c.Posts.PostId == postId).ToList();
        }

        public IList<Comments> GetCommentsForPost(Posts post)
        {
            return context.Comments.Where(c => c.Posts.PostId == post.PostId).ToList();
        }
    }
}
