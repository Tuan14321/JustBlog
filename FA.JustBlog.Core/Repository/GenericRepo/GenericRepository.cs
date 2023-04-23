using FA.JustBlog.Core.DataContext;
using Microsoft.EntityFrameworkCore;


namespace FA.JustBlog.Core.Repository.GenericRepo
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly JustBlogContext context;
        protected DbSet<TEntity> dbSet;

        public GenericRepository(JustBlogContext context = null)
        {
            this.context = context ?? new JustBlogContext();
            dbSet = this.context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            dbSet.Add(entity);

        }

        public void CreateRange(TEntity entity)
        {
            dbSet.AddRange(entity);
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public void Delete(int id)
        {
            dbSet.Remove(dbSet.Find(id));
        }

        public TEntity Find(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateRange(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
