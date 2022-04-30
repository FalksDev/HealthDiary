using HealthDiary.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthDiary.Infrastructure.Data;

public interface IApplicationDBContext
{
    DbSet<User> Users { get; set; }
    Task<int> SaveChangesAsync();
}