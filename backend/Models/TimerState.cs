#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace Server.Models;
public class TimerState
{
    [Key]
    public int TimerStateId { get; set; }
    public int TimerId { get; set; }
    [Required]
    public bool InProgress { get; set; }
    [Required]
    public int CurrentTime { get; set; }
    [Required]
    public string Activity { get; set; }
    [Required]
    public int SetsCompleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public Timer Timer { get; set; }
}