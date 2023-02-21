#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace Server.Models;
public class Timer
{
    [Key]
    public int TimerId { get; set; }
    public int UserId { get; set; }
    [Required]
    [MinLength(2)]
    public string Name { get; set; }
    [Required]
    [Range(1, 1000)]
    public int ExerciseTime { get; set; }
    [Required]
    [Range(1, 1000)]
    public int RestTime { get; set; }
    [Required]
    [Range(1, 1000)]
    public int Sets { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public TimerState TimerState { get; set; }
}