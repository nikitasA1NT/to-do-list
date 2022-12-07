namespace TodoList.Domain.Entity;

/// <summary>
/// Tag.
/// </summary>
public class Tag
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// User unique identifier.
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Name.
    /// </summary>
    public string Name { get; set; }
}