using todo.Interfaces;

namespace todo;

public class TaskService(ITaskRepository taskRepository) : ITaskService
{
    public Task<ITask> GetTask(Guid id)
    {
        return taskRepository.GetTask(id);
    }

    public Task AddTask(ITask task)
    {
        return taskRepository.AddTask(task);
    }
}