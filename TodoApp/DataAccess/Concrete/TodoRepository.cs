using TodoApp.DataAccess.Abstract;
using TodoApp.DataAccess.Context;
using TodoApp.Entity.Concrete;

namespace TodoApp.DataAccess.Concrete;

public class TodoRepository : GenericRepository<Todo>, ITodoRepository
{
    public TodoRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
