using todo.Interfaces;
using Task = todo.Entities.Task;

namespace todo.UseCases;

public class CreateTask(ITaskRepository taskRepository) : ICreateTask
{
    public async Task<ITask?> Execute(string description)
    {
        var task = new Task(description);
        await taskRepository.AddTask(task);
        return task;
    }
}