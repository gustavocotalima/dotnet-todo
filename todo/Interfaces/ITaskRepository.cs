using todo.Interfaces;

namespace todo.Interfaces;

public interface ITaskRepository
{
    Task<ITask> GetTask(Guid id);
    Task<IEnumerable<ITask>> GetAllTasks();
    Task AddTask(ITask task);
    Task UpdateTask(ITask task);
    Task DeleteTask(Guid id);
}