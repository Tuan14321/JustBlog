using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA.JustBlog.Core.Config
{
    public class CommentConfig : IEntityTypeConfiguration<Comments>
    {
        public void Configure(EntityTypeBuilder<Comments> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x => x.CommentId);


            builder.HasOne(x => x.Posts).WithMany(x => x.Comments).HasForeignKey(x => x.PostId);

        }
    }
}
