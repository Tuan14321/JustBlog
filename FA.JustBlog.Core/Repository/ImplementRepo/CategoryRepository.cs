using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repository.GenericRepo;
using FA.JustBlog.Core.Repository.IRespository;

namespace FA.JustBlog.Core.Repository.ImplementRepo
{
    public class CategoryRepository : GenericRepository<Categories>, ICategoryRepository
    {
        public CategoryRepository(JustBlogContext context) : base(context)
        {
        }
    }
}
