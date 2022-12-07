namespace TodoList.Domain.Entity;

/// <summary>
/// Tag in task.
/// </summary>
public class TagInTask
{
    /// <summary>
    /// Tag unique identifier.
    /// </summary>
    public Guid TagId { get; set; }
    
    /// <summary>
    /// To-do list task unique identifier.
    /// </summary>
    public Guid TodoTaskId { get; set; }
}