using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repository.GenericRepo;

namespace FA.JustBlog.Core.Repository.IRespository
{
    public interface ITagRepository : IGenericRepository<Tags>
    {
        Tags GetTagByUrlSlug(string urlSlug);

        IEnumerable<Tags> GetTagByPost(int postId);


    }
}
