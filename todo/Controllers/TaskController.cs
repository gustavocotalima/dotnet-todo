using Microsoft.AspNetCore.Mvc;
using todo.Interfaces;
using Task = todo.Entities.Task;

namespace todo.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController(ITaskService taskService) : BaseController
{
    [HttpGet]
    [Route("{id:guid:required}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetTask([FromRoute] Guid id)
    {
        var task = await taskService.GetTask(id);
        
        return Ok(task);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CreateTask([FromBody] string description)
    {
        var task = new Task(description);

        await taskService.AddTask(task);
        return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);
    }
}