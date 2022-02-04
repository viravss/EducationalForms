using Domain.Models.BaseModel;

namespace Domain.Models;

public class Consultant : ModelBase
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
}