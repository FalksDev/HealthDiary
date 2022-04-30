using System.ComponentModel.DataAnnotations;

namespace HealthDiary.Core.Entities.Base;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }    
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedOn { get; set; }
    public DateTime LastAccessed { get; set; }
}