using Microsoft.EntityFrameworkCore;

namespace RsvpApp.Models
{
    public class RsvpContext : DbContext
    {
        public RsvpContext(DbContextOptions<RsvpContext> options) : base(options)
        {
        }

        public DbSet<Rsvp> Rsvps { get; set; }
    }
}
