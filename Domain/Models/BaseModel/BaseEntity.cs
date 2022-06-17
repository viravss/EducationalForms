using System.ComponentModel.DataAnnotations;

namespace Domain.Models.BaseModel;

public class BaseEntity : IdentityBaseEntity
{
    public DateTime CreateOn { get; set; }
    public DateTime? ModifyOn { get; set; }
}