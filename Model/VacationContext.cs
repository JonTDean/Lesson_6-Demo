using Microsoft.EntityFrameworkCore;

namespace RestfulWebAPI.Models
{
    public class VacationContext : DbContext
    {
        public VacationContext(DbContextOptions<VacationContext> options) : base(options) {}

        public DbSet<Vacation> Vacations { get; set; }
    }
}