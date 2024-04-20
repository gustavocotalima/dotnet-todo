using todo.Interfaces;

namespace todo.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly List<ITask> tasks = new();

    public Task<ITask> GetTask(Guid id)
    {
        return Task.FromResult(tasks.FirstOrDefault(t => t.Id == id));
    }

    public Task<IEnumerable<ITask>> GetAllTasks()
    {
        return Task.FromResult(tasks.AsEnumerable());
    }

    public Task AddTask(ITask task)
    {
        tasks.Add(task);
        return Task.CompletedTask;
    }
}

