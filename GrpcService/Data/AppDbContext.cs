using GrpcServer.Data.Helpers;
using Microsoft.EntityFrameworkCore;

namespace GrpcServer.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }
    public DbSet<BookModel>? Books { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        DataSeeder.SeedData(builder);
        base.OnModelCreating(builder);
    }
}
