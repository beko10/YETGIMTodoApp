using TodoApp.Entity.Abstract;

namespace TodoApp.Entity.Concrete;

public class Todo : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }

    public Todo()
    {
        Title = string.Empty;
        Description = string.Empty;
    }
}
