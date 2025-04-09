using TodoApp.Entity.Abstract;

namespace TodoApp.DataAccess.Abstract;

public interface IGenericRepository<TEntity> where TEntity : BaseEntity
{
    void Add(TEntity entity);
    void Delete(TEntity entity);
    void Update(TEntity entity);
    List<TEntity> GetAll();
    TEntity GetById(int id);
}
