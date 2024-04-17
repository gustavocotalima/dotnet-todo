using todo.Interfaces;

namespace todo.Repositories;

public class TaskRepository : ITaskRepository
{
    public Task<ITask> GetTask(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ITask>> GetAllTasks()
    {
        throw new NotImplementedException();
    }

    public Task AddTask(ITask task)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTask(ITask task)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTask(Guid id)
    {
        throw new NotImplementedException();
    }
    
}