using Domain.Models.BaseModel;

namespace Domain.Models;

public class FailureReason:IdentityBaseEntity
{
    public string Name { get; set; }
    public bool IsActive { get; set; }

    
}