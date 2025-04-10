using TodoApp.Business.Abstract;
using TodoApp.Business.Concrete;
using TodoApp.DataAccess.Abstract;
using TodoApp.DataAccess.Concrete;
using TodoApp.DataAccess.Context;
using TodoApp.Entity.Concrete;

namespace TodoApp
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;
        private ITodoRepository _todoRepository;
        private ITodoService _todoService;

        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _todoRepository = new TodoRepository(_context);
            _todoService = new TodoManager(new TodoRepository(_context));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiðinde yapýlacak iþlemler
            // Örneðin, veritabanýndan todo'larý listeleme
            lstTodo.DataSource = _todoService.GetAllTodos();
            lstTodo.DisplayMember = "Title"; // Görüntülenecek alan
            lstTodo.ValueMember = "Id"; // Seçilen deðerin Id olmasý
            lstTodo.SelectedIndexChanged += lstTodo_SelectedIndexChanged;
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            Todo todo = new()
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                DueDate = dtmDueDate.Value
            };
            _todoService.Add(todo);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lstTodo.SelectedValue);
            _todoService.Delete(id);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lstTodo.SelectedValue);
            var updatedTodo = _todoService.GetTodoById(id);
            updatedTodo.Title = txtTitle.Text;
            updatedTodo.Description = txtDescription.Text;
            updatedTodo.DueDate = dtmDueDate.Value;
            _todoService.Update(updatedTodo);

        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            lstTodo.DisplayMember = "Title";
            lstTodo.ValueMember = "Id";
            lstTodo.DataSource = _todoService.GetAllTodos();
        }

        private void lstTodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lstTodo.SelectedValue);
            Todo todo = _todoService.GetTodoById(id);
            if (lstTodo.SelectedItem is not null)
            {
                txtTitle.Text = todo.Title;
                txtDescription.Text = todo.Description;
                dtmDueDate.Value = todo.DueDate;
            }
        }

   
    }
}
