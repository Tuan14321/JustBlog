using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repository.GenericRepo;

namespace FA.JustBlog.Core.Repository.IRespository
{
    public interface ICommentRepository : IGenericRepository<Comments>
    {
        IList<Comments> GetCommentsForPost(int postId);
        IList<Comments> GetCommentsForPost(Posts post);
        void AddComment(int postId, string commentName, string commentEmail, string commentTitle, string commentBody);
    }
}
