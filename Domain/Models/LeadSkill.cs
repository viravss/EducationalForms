using Domain.Models.BaseModel;

namespace Domain.Models;

public class LeadSkill : IdentityBaseEntity
{
    public LeadSkill()
    {
        Skills = new HashSet<Skill>();
    }
    public int LeadId { get; set; }
    public virtual Lead Lead { get; set; }
    public ICollection<Skill> Skills { get; set; }
}