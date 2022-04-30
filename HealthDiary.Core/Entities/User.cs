using HealthDiary.Core.Entities.Base;

namespace HealthDiary.Core.Entities;

public class User : BaseEntity
{
    public string UserName { get; set; }
    public string Password { get; set; }
}