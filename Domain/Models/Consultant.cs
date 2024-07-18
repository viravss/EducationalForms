using Domain.Models.BaseModel;

namespace Domain.Models;

public class Consultant : IdentityBaseEntity
{
    public string Name { get; set; }
    public string Family { get; set; }
    public bool IsActive { get; set; }

    public virtual User User { get; set; }
}