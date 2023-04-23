using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Repository.ImplementRepo;
using FA.JustBlog.Core.Repository.IRespository;

namespace FA.JustBlog.Core.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JustBlogContext? _context;
        private ICategoryRepository categoryRepository;
        private IPostRepository postRepository;
        private ITagRepository tagRepository;
        private ICommentRepository commentRepository;

        public UnitOfWork(JustBlogContext context = null)
        {
            _context = context ?? new JustBlogContext();
        }


        public ICategoryRepository CategoryRepository => categoryRepository ?? new CategoryRepository(_context);

        public IPostRepository PostRepository => postRepository ?? new PostRepository(_context);

        public ITagRepository TagRepository => tagRepository ?? new TagRepository(_context);

        public ICommentRepository CommentRepository => commentRepository ?? new CommentRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }
            this._context?.Dispose();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

    }
}
