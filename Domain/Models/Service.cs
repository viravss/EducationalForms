using Domain.Models.BaseModel;

namespace Domain.Models;

public class Service : IdentityBaseEntity
{
    public string Name { get; set; }
}