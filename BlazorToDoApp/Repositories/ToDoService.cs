using BlazorToDoApp.Models;

namespace BlazorToDoApp.Repositories;

public class ToDoService
{
    public List<ToDoModel> todos { get; set; }

    public ToDoService()
    {
        todos = new()
        {
            new ToDoModel { id = 1, desc = "First Task" },
            new ToDoModel { id = 2, desc = "Second Task" },
            new ToDoModel { id = 3, desc = "Third Task" },
            new ToDoModel { id = 4, desc = "Fourth Task" },
        };
    }

    public void AddToDo()
    {
        int newId = todos.Any() ? todos.Max(item => item.id) + 1 : 1;
        var newToDo = new ToDoModel { id = newId, desc = "New Todo" };
        todos.Add(newToDo);
    }

    public List<ToDoModel> GetAllToDos()
    {
        return todos.OrderByDescending(item => item.id).ToList();
    }

    public void EditToDo(int todoId, ToDoModel todo)
    {
        var todoToUpdate = todos.Find(item => item.id == todoId);
        if (todoToUpdate is not null)
        {
            todoToUpdate.desc = todo.desc;
            todoToUpdate.completed = todo.completed;
        }
    }
}
