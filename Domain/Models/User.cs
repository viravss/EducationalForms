using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;
using Domain.Models.BaseModel;

namespace Domain.Models;

public class User : IdentityBaseEntity
{
    public string UserName { get; set; }
    public string CellPhone { get; set; }
    public string Password { get; set; }
    public RoleTypeEnum RoleType { get; set; }
    public bool IsActive { get; set; }
    [ForeignKey("ConsultantId")]
    public int ConsultantId { get; set; }
    public virtual Consultant Consultant { get; set; }
}