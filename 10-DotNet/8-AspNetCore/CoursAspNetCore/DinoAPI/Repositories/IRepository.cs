using System.Linq.Expressions;

namespace DinoAPI.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public Task<bool> Add (TEntity entity);
        public Task<bool> Update (TEntity entity);
        public Task<bool> Delete (int id);
        public Task<TEntity?> GetById (int id);
        public Task<IEnumerable<TEntity>> GetAll();
        public Task<TEntity?> Get(Expression<Func<TEntity, bool>> predicate);
        public Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate);
    }
}
