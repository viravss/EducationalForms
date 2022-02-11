using System.ComponentModel.DataAnnotations;

namespace Domain.Models.BaseModel;

public class IdentityBaseEntity
{
    [Key]
    public int Id { get; set; }
}