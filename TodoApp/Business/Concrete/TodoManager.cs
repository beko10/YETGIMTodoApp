using TodoApp.Business.Abstract;
using TodoApp.DataAccess.Abstract;
using TodoApp.Entity.Concrete;

namespace TodoApp.Business.Concrete;

public class TodoManager : ITodoService
{
    private readonly ITodoRepository _todoRepository;

    public TodoManager(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public void AddTodo(Todo todo)
    {
        //iş kuralları sağlanırsa eklenir
        _todoRepository.Add(todo);
        //iş kuralları sağlanmazsa hata fırlatılır
    }

    public void DeleteTodo(int id)
    {
        //silinecek todo var mı kontrol et
        var deletedTodo = _todoRepository.GetById(id);
        //silinecek todo var ise sil
        if (deletedTodo != null)
        {
            _todoRepository.Delete(deletedTodo);
        }
    }

    public List<Todo> GetAllTodos()
    {
        //tüm todo'ları getir
        return _todoRepository.GetAll();
    }

    public Todo GetTodoById(int id)
    {
        //id'si verilen todo'yu getir
        return _todoRepository.GetById(id);
    }

    public void UpdateTodo(Todo todo)
    {
        //güncellenecek todo var mı kontrol et
        var updatedTodo = _todoRepository.GetById(todo.Id);
        //güncellenecek todo var ise güncelle
        if (updatedTodo != null)
        {
            //güncellenecek todonun ilgili propertilerini parametreden gelen tododan al 
            updatedTodo.Title = todo.Title;
            updatedTodo.Description = todo.Description;
            updatedTodo.DueDate = todo.DueDate;
            _todoRepository.Update(updatedTodo);
        }
    }
}
