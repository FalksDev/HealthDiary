using HealthDiary.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthDiary.Infrastructure.Data;

public class ApplicationDBContext : DbContext, IApplicationDBContext
{
    public DbSet<User> Users { get; set; }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        
        InitializeSeed(modelBuilder);
    }

    private void InitializeSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = Guid.NewGuid(),
                UserName = "test",
                Password = "password",
                CreatedOn = DateTime.Now,
                LastAccessed = DateTime.Now
            });
    }

    public async Task<int> SaveChangesAsync()
    {
        return await base.SaveChangesAsync();
    }
}