using TodoApp.Entity.Concrete;

namespace TodoApp.Business.Abstract;

public interface ITodoService
{
    void AddTodo(Todo todo);
    void UpdateTodo(Todo todo);
    void DeleteTodo(int id);
    Todo GetTodoById(int id);
    List<Todo> GetAllTodos();
}
