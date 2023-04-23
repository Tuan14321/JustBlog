using FA.JustBlog.Core.Config;
using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.DataContext
{
    public class JustBlogContext : DbContext
    {
        public JustBlogContext()
        {

        }
        public JustBlogContext(DbContextOptions<JustBlogContext> options) : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<PostTagMap> PostTagMaps { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=FAJustBlogUIContext;Integrated Security=True";
                optionsBuilder.UseSqlServer(connectionString);
                //optionsBuilder.EnableSensitiveDataLogging();
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TagsConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostTagMapConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CommentConfig).Assembly);

            modelBuilder.SeedData();
        }



    }
}
