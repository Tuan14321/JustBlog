using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA.JustBlog.Core.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.CategoryId);

            builder.Property(x => x.CategoryName).IsRequired();
            builder.Property(x => x.UrlSlug).IsRequired();
        }
    }
}
