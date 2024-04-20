using Microsoft.EntityFrameworkCore;

namespace todo.Repositories;

public class TodoDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Task> Tasks { get; set; }
}