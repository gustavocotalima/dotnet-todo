using todo.Entities;

namespace todo.Interfaces;

public interface ICreateTask
{
    Task<ITask?> Execute(string description);
}