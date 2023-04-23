using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA.JustBlog.Core.Config
{
    public class TagsConfig : IEntityTypeConfiguration<Tags>
    {
        public void Configure(EntityTypeBuilder<Tags> builder)
        {
            builder.ToTable("Tags");
            builder.HasKey(x => x.TagId);

            builder.Property(x => x.TagName).IsRequired();
            builder.Property(x => x.UrlSlug).IsRequired();
        }
    }
}
