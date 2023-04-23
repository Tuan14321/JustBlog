using FA.JustBlog.Core.DataContext;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repository.GenericRepo;
using FA.JustBlog.Core.Repository.IRespository;

namespace FA.JustBlog.Core.Repository.ImplementRepo
{
    public class TagRepository : GenericRepository<Tags>, ITagRepository
    {
        public TagRepository(JustBlogContext context) : base(context)
        {
        }

        public Tags GetTagByUrlSlug(string urlSlug)
        {
            return context.Tags.FirstOrDefault(t => t.UrlSlug.Contains(urlSlug));

        }

        IEnumerable<Tags> ITagRepository.GetTagByPost(int postId)
        {
            return context.PostTagMaps
                      .Join(context.Tags, postTag => postTag.TagId, tag => tag.TagId, (postTag, tag) => new { postTag, tag })
                      .Where(joinResult => joinResult.postTag.PostId == postId)
                      .Select(joinResult => joinResult.tag);
        }
    }
}

