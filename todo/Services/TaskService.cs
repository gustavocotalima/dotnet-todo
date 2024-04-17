using todo.Interfaces;

namespace todo;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public Task<ITask> GetTask(Guid id)
    {
        return _taskRepository.GetTask(id);
    }

    public Task<IEnumerable<ITask>> GetAllTasks()
    {
        return _taskRepository.GetAllTasks();
    }

    public Task AddTask(ITask task)
    {
        return _taskRepository.AddTask(task);
    }

    public Task UpdateTask(ITask task)
    {
        return _taskRepository.UpdateTask(task);
    }

    public Task DeleteTask(Guid id)
    {
        return _taskRepository.DeleteTask(id);
    }
}