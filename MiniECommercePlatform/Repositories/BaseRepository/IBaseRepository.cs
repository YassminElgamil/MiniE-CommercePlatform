namespace MiniECommercePlatform;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    public Task<TEntity> Create(TEntity entity);
    public Task<TEntity> Update(TEntity entity);
    public Task<TEntity> Delete(TEntity entity);
    public Task<TEntity?> GetById(Guid id);
    public Task<IQueryable<TEntity>?> Get();
    public Task<IQueryable<TEntity>> Get(Expression<Func<TEntity, bool>> expression);
}