using Microsoft.EntityFrameworkCore;
using MVC_To_Do_List.Repository.Models;

namespace MVC_To_Do_List;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Todo_List> TodoList { get; set; }
}