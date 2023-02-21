using Microsoft.EntityFrameworkCore;
namespace Server.Models
{
    public class ETContext : DbContext
    {
        public ETContext(DbContextOptions<ETContext> options) : base(options) { }
        public DbSet<Timer> Timers { get; set; } = null!;
        public DbSet<TimerState> TimerStates { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
    }
 }