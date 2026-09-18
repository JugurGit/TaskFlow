namespace TaskFlow.Cli.Models;

public class TaskItem
{
    public int Id { get; set; }

    public string Title { get; set; }

    public bool IsCompleted { get; set; }

    public TaskItem(int id, string title)
    {
        Id = id;
        Title = title;
        IsCompleted = false;
    }

    public void Complete()
    {
        IsCompleted = true;
    }
}