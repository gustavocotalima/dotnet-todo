using todo.Interfaces;

namespace todo.Entities;

public class Task(string description) : ITask
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Description { get; private set; } = description;
    public DateTime CompletedAt { get; private set; } = DateTime.MinValue;

    public void CompleteTask()
    {
        CompletedAt = DateTime.Now;
    }
}