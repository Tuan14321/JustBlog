using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repository.GenericRepo;
using FA.JustBlog.Core.Repository.IRespository;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Repository.ImplementRepo
{
    public class PostRepository : GenericRepository<Posts>, IPostRepository
    {
        public PostRepository(JustBlogContext context) : base(context)
        {
        }

        public int CountPostsForCategory(string category)
        {
            return context.Posts.Where(p => p.Category.CategoryName.ToLower() == category.ToLower()).Count();

        }

        public int CountPostsForTag(string tag)
        {
            return context.Posts.Where(p => context.PostTagMaps
                                .Join(context.Tags, ptm => ptm.TagId, t => t.TagId, (ptm, t) => new { ptm, t })
                                .Where(pt => pt.t.TagName.ToLower() == tag.ToLower() && pt.ptm.PostId == p.PostId)
                                .Any())
                                .Count();
        }

        public Posts FindPost(int year, int month, string urlSlug)
        {
            return context.Posts.FirstOrDefault(p => p.Modified.Year == year && p.Modified.Month == month && p.UrlSlug == (urlSlug));
        }

        public IList<Posts> GetHighestPosts(int size)
        {
            return context.Posts.OrderByDescending(p => p.RateCount).Take(size).ToList();
        }

        public IList<Posts> GetLatestPost(int size)
        {
            return context.Posts
               .OrderByDescending(p => p.PostOn)
               .Take(size)
               .ToList();
        }

        public IList<Posts> GetMostViewedPost(int size)
        {
            return context.Posts.OrderByDescending(p => p.ViewCount).Take(size).ToList();
        }

        public IList<Posts> GetPostsByCategory(string category)
        {
            return context.Posts.Where(p => p.Category.CategoryName.ToLower() == category.ToLower()).ToList();
        }

        public IList<Posts> GetPostsByMonth(DateTime monthYear)
        {
            return context.Posts.Where(p => p.PostOn.Month.Equals(monthYear.Month)).ToList();
        }

        public IList<Posts> GetPostsByTag(string tag)
        {
            return context.Posts.Where(p => context.PostTagMaps
                                        .Where(ptm => context.Tags
                                                             .Where(t => t.TagName.ToLower() == tag.ToLower())
                                                             .Select(t => t.TagId)
                                                             .Contains(ptm.TagId))
                                        .Select(ptm => ptm.PostId)
                                        .Contains(p.PostId)).ToList();
        }

        public IList<Posts> GetPublisedPosts()
        {
            return context.Posts.Where(p => p.Published == true).ToList();
        }

        public IList<Posts> GetUnpublisedPosts()
        {
            return context.Posts.Where(p => p.Published == false).ToList();

        }
    }
}
