using todo.Entities;

namespace todo.Interfaces;

public interface IGetTaskById
{
    Task<ITask?> Execute(Guid id);
}