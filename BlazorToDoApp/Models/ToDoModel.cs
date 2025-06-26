namespace BlazorToDoApp.Models;

public class ToDoModel
{
    public int id { get; set; }
    private string desc;

    public string Desc
    {
        get { return desc; }
        set { desc = value; }
    }
    public bool completed { get; set; } = false;
}
