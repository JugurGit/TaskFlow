using TaskFlow.Cli.Models;

var tasks = new List<TaskItem>();

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("=== TASKFLOW ===");
    Console.WriteLine();

    Console.WriteLine("1. Add a task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("3. Exit");

    Console.WriteLine();
    Console.Write("Choose an option: ");

    string? choice = Console.ReadLine();

    Console.WriteLine();

    switch (choice)
    {
        case "1":

            Console.Write("Task title: ");
            string? title = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Task title cannot be empty.");
                break;
            }

            Console.Write("Priority (Low / Medium / High): ");
            string? priority = Console.ReadLine();

            string[] validPriorities =
            {
                "Low",
                "Medium",
                "High"
            };

            if (
                string.IsNullOrWhiteSpace(priority) ||
                !validPriorities.Contains(
                    priority,
                    StringComparer.OrdinalIgnoreCase
                )
            )
            {
                Console.WriteLine("Invalid priority.");
                break;
            }

            string normalizedPriority =
            validPriorities.First(p =>
                p.Equals(
                    priority,
                    StringComparison.OrdinalIgnoreCase
                )
            );
            int id = tasks.Count + 1;

            var task = new TaskItem(
                id,
                title,
                normalizedPriority
            );

            tasks.Add(task);

            Console.WriteLine();
            Console.WriteLine($"Task \"{task.Title}\" created.");

            break;

        case "2":

            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks.");
                break;
            }

            foreach (TaskItem taskItem in tasks)
            {
                Console.WriteLine(
                    $"{(taskItem.IsCompleted ? "[X]" : "[ ]")} " +
                    $"{taskItem.Id}. {taskItem.Title} " +
                    $"(Priority: {taskItem.Priority})"
                );
            }

            break;

        case "3":

            running = false;
            Console.WriteLine("Goodbye!");

            break;

        default:

            Console.WriteLine("Invalid option.");

            break;
    }
}