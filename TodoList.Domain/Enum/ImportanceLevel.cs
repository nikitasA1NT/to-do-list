using System.ComponentModel.DataAnnotations;

namespace TodoList.Domain.Enum;

/// <summary>
/// Importance level.
/// </summary>
public enum ImportanceLevel : short
{
    [Display(Name = "Minimum importance level")]
    Minimum = 1,
    [Display(Name = "Small importance level")]
    Small = 2,
    [Display(Name = "Average importance level")]
    Average = 3,
    [Display(Name = "Big importance level")]
    Big = 4,
    [Display(Name = "Maximum importance level")]
    Maximum = 5
}