using JPProject.Domain.Core.Events;
using JPProject.Admin.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace JPProject.Admin.Infra.Data.Context
{
    public class EventStoreContext : DbContext
    {
        public DbSet<StoredEvent> StoredEvent { get; set; }
        public DbSet<EventDetails> StoredEventDetails { get; set; }
        public EventStoreContext(DbContextOptions<EventStoreContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoredEventMap());
            modelBuilder.ApplyConfiguration(new EventDetailsMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
