using Microsoft.EntityFrameworkCore;
using TodoApp.Entity.Concrete;

namespace TodoApp.DataAccess.Context;

public class AppDbContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-JH4RF0R;Database=TodoAppDb;Trusted_Connection=True;Encrypt=False;");
    }


}
