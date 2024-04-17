using Microsoft.AspNetCore.Mvc;
using todo.Interfaces;
using Task = todo.Entities.Task;

namespace todo.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController(ITaskService taskService) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTask(Guid id)
    {
        var task = await taskService.GetTask(id);

        return Ok(task);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTask([FromBody] string description)
    {
        var task = new Task(description);

        await taskService.AddTask(task);
        return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);
    }
}