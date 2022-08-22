using MVC_To_Do_List.Repository.Models;

namespace MVC_To_Do_List;

public interface ITodoService
{
    public List<Todo_List> Get(int id);
}

public class TodoService : ITodoService
{
    private readonly DataContext _dataContext;

    public TodoService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public List<Todo_List> Get(int id)
    {
        return _dataContext.TodoList.Where(x => x.Id == id).ToList();
    }
}