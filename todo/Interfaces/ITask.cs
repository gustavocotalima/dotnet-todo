namespace todo.Interfaces;

public interface ITask
{
    Guid Id { get; }
    string Description { get; }
    DateTime CompletedAt { get; }
}