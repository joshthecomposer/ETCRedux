#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models;
public class User
{
    [Key]
    public int UserId { get; set; }
    [Required]
    [MinLength(2)]
    public string FirstName { get; set; }
    [Required]
    [MinLength(2)]
    public string LastName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(8)]
    [Compare("Confirm")]
    public string Password { get; set; }
    [NotMapped]
    public string Confirm { get; set; }
    public DateTime CreatedAt{ get; set; }
    public DateTime UpdateAt{ get; set; }

    public List<Timer> AllTimers { get; set; } = new List<Timer>();
}