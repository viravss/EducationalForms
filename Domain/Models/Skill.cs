using Domain.Models.BaseModel;

namespace Domain.Models;

public class Skill : IdentityBaseEntity
{
    public Skill()
    {
        LeadSkills = new HashSet<LeadSkill>();
    }
    public string Name { get; set; }
    public long Price { get; set; }
    public int Time { get; set; }
    public ICollection<LeadSkill> LeadSkills { get; set; }
}