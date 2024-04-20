using todo.Interfaces;
using todo.Repositories;

namespace todo.Extensions;

public static class Extensions
{
    public static IServiceCollection AddToDoServices(this IServiceCollection services)
        => services
            .AddScoped<ITaskRepository, TaskRepository>()
            .AddScoped<ITaskService, TaskService>();
}