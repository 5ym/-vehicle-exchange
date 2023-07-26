using Microsoft.EntityFrameworkCore;

namespace BackendVE.Models;

public class BackendVEContext : DbContext
{
    public BackendVEContext(DbContextOptions<BackendVEContext> options)
        : base(options)
    {
    }

    public static readonly string RowVersion = nameof(RowVersion);

    public required DbSet<User> Users { get; set; }
    public required DbSet<Car> Cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .Property<byte[]>(RowVersion)
            .IsRowVersion();
        modelBuilder.Entity<Car>()
            .Property<byte[]>(RowVersion)
            .IsRowVersion();
        base.OnModelCreating(modelBuilder);
    }
}