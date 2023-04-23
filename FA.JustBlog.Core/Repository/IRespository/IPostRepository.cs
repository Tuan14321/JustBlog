using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repository.GenericRepo;

namespace FA.JustBlog.Core.Repository.IRespository
{
    public interface IPostRepository : IGenericRepository<Posts>
    {
        IList<Posts> GetPublisedPosts();
        IList<Posts> GetUnpublisedPosts();
        IList<Posts> GetLatestPost(int size);
        IList<Posts> GetPostsByMonth(DateTime monthYear);
        int CountPostsForCategory(string category);
        IList<Posts> GetPostsByCategory(string category);
        Posts FindPost(int year, int month, string urlSlug);
        int CountPostsForTag(string tag);
        IList<Posts> GetPostsByTag(string tag);
        IList<Posts> GetMostViewedPost(int size);
        IList<Posts> GetHighestPosts(int size);
    }
}
