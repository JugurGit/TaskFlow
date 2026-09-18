namespace TaskFlow.Cli.Models;

public class TaskItem
{
    public int Id { get; set; }

    public string Title { get; set; }

    public bool IsCompleted { get; set; }

    public string Priority { get; set; }

    public TaskItem(int id, string title, string priority)
{
    Id = id;
    Title = title;
    Priority = priority;
    IsCompleted = false;
}

    public void Complete()
    {
        IsCompleted = true;
    }
}