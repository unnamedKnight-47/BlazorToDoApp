using BlazorToDoApp.Models;

namespace BlazorToDoApp.Repositories;

public static class ToDoService
{
    public static List<ToDoModel> todos { get; set; } = new()
    {
        new ToDoModel { id = 1, Desc = "First Task" },
        new ToDoModel { id = 2, Desc = "Second Task" },
        new ToDoModel { id = 3, Desc = "Third Task" },
        new ToDoModel { id = 4, Desc = "Fourth Task" },
    };


    public static void AddToDo()
    {
        int newId = todos.Any() ? todos.Max(item => item.id) + 1 : 1;
        var newToDo = new ToDoModel { id = newId, Desc = "New Todo" };
        todos.Add(newToDo);
    }

    public static List<ToDoModel> GetAllToDos()
    {
        return todos.OrderByDescending(item => item.id).ToList();
    }

    public static void EditToDo(int todoId, ToDoModel todo)
    {
        var todoToUpdate = todos.Find(item => item.id == todoId);
        if (todoToUpdate is not null)
        {
            todoToUpdate.Desc = todo.Desc;
            todoToUpdate.completed = todo.completed;
        }
    }
}
