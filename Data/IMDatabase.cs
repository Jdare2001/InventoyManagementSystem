
using Microsoft.EntityFrameworkCore;

public class IMDatabaseContext : DbContext{
    public IMDatabaseContext(DbContextOptions<IMDatabaseContext> options) : base(options) { }

    public DbSet<Item> Items { get; set; }
    public DbSet<Delivery> Deliveries { get; set;}
}