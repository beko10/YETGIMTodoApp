using Microsoft.EntityFrameworkCore;
using TodoApp.DataAccess.Abstract;
using TodoApp.DataAccess.Context;
using TodoApp.Entity.Abstract;

namespace TodoApp.DataAccess.Concrete;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
{

    private readonly AppDbContext _appDbContext;
    private DbSet<TEntity> _db;   

    public GenericRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
        _db = _appDbContext.Set<TEntity>(); 
    }

    public void Add(TEntity entity)
    {
        
        _db.Add(entity);//_appDbContext.Entry(entity).State = EntityState.Added;
        _appDbContext.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        _db.Remove(entity); 
        _appDbContext.SaveChanges();
    }

    public List<TEntity> GetAll()
    {
        return _db.ToList();
    }

    public TEntity GetById(int id)
    {
        return _db.FirstOrDefault(x => x.Id == id);
    }

    public void Update(TEntity entity)
    {
        _db.Update(entity);
        _appDbContext.SaveChanges();
    }
}
