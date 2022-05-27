using Domain.Models.BaseModel;

namespace Domain.Models;

public class FamiliarityMethod:IdentityBaseEntity
{
    public string Name { get; set; }
    public bool IsActive { get; set; }
    
    
}