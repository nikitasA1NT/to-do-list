namespace TodoList.Domain.Entity;

/// <summary>
/// User.
/// </summary>
public class User
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Nickname.
    /// </summary>
    public string Nickname { get; set; }
    
    /// <summary>
    /// Password.
    /// </summary>
    public string Password { get; set; }
}