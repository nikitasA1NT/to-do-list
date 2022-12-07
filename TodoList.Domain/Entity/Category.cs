namespace TodoList.Domain.Entity;

/// <summary>
/// Category.
/// </summary>
public class Category
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