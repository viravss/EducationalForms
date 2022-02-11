using System.ComponentModel.DataAnnotations;
using Domain.Models.BaseModel;

namespace Domain.Models;

public class Skill : IdentityBaseEntity
{
    public string Title { get; set; }
}