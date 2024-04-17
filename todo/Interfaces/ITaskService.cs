namespace todo.Interfaces;

public interface ITaskService
{
    Task<ITask> GetTask(Guid id);
    Task<IEnumerable<ITask>> GetAllTasks();
    Task AddTask(ITask task);
    Task UpdateTask(ITask task);
    Task DeleteTask(Guid id);
}