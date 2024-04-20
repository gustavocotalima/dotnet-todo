using todo.Interfaces;

namespace todo.UseCases;

public class GetTaskById(ITaskRepository taskRepository) : IGetTaskById
{
    public async Task<ITask?> Execute(Guid id)
    {
        return await taskRepository.GetTask(id);
    }
}
