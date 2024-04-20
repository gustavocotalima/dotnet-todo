using todo.Interfaces;

namespace todo.Interfaces;

public interface ITaskRepository
{
    Task<ITask> GetTask(Guid id);
    Task AddTask(ITask task);
}