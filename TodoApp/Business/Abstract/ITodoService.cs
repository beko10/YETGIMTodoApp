using TodoApp.Entity.Concrete;

namespace TodoApp.Business.Abstract;

public interface ITodoService
{
    void Add(Todo todo);
    void Update(Todo todo);
    void Delete(int id);
    Todo GetTodoById(int id);
    List<Todo> GetAllTodos();
}
