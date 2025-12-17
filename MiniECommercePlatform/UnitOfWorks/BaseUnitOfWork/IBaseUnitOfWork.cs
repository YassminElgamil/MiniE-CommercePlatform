namespace MiniECommercePlatform;

public interface IBaseUnitOfWork<TEntity> where TEntity : BaseEntity
{
    public Task<TEntity> Create(TEntity entity);
    public Task<TEntity> Update(TEntity entity);
    public Task Delete(TEntity entity);
    public Task<TEntity> Read(Guid id);
    public Task<IQueryable<TEntity>> Read();
    public Task<IQueryable<TEntity>> Read(Expression<Func<TEntity,bool>> expression);
}