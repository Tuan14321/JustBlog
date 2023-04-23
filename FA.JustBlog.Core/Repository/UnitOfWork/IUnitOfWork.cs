using FA.JustBlog.Core.Repository.IRespository;

namespace FA.JustBlog.Core.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        IPostRepository PostRepository { get; }
        ITagRepository TagRepository { get; }
        ICommentRepository CommentRepository { get; }
        int SaveChanges();

    }
}
