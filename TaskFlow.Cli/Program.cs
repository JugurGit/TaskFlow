using TaskFlow.Cli.Models;

var task = new TaskItem("Learn Git");

Console.WriteLine(task.Title);

Console.WriteLine();
Console.WriteLine("=== TASKFLOW ===");
Console.WriteLine();

Console.WriteLine("1. Add task");
Console.WriteLine("2. List tasks");
Console.WriteLine("3. Exit");

Console.WriteLine();
Console.Write("Choose an option: ");