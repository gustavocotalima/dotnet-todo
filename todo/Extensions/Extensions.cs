using todo.Interfaces;
using todo.Repositories;
using todo.UseCases;

namespace todo.Extensions;

public static class Extensions
{
    public static IServiceCollection AddToDoServices(this IServiceCollection services)
        => services
            .AddScoped<ITaskRepository, TaskRepository>()
            .AddScoped<ITaskService, TaskService>()
            .AddScoped<ICreateTask, CreateTask>()
            .AddScoped<IGetTaskById, GetTaskById>();
}