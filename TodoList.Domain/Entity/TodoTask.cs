using TodoList.Domain.Enum;

namespace TodoList.Domain.Entity;

/// <summary>
/// To-do list task.
/// </summary>
public class TodoTask
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Category unique identifier.
    /// </summary>
    public Guid CategoryId { get; set; }
    
    /// <summary>
    /// Title.
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Body.
    /// </summary>
    public string Body { get; set; }
    
    /// <summary>
    /// Creation date and time.
    /// </summary>
    public DateTime CreationDate { get; set; }
    
    /// <summary>
    /// Edit date and time.
    /// </summary>
    public DateTime EditDate { get; set; }
    
    /// <summary>
    /// Importance level.
    /// </summary>
    public ImportanceLevel ImportanceLevel { get; set; }
    
    /// <summary>
    /// Is task completed.
    /// </summary>
    public bool IsCompleted { get; set; }
}