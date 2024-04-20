namespace todo.Interfaces;

public interface ITaskService
{
    Task<ITask> GetTask(Guid id);
    Task AddTask(ITask task);
}