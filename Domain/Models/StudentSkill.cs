using Domain.Models.BaseModel;

namespace Domain.Models;

public class StudentSkill:IdentityBaseEntity
{
    public StudentSkill()
    {
        Skills = new HashSet<Skill>();
    }
    public int StudentId { get; set; }
    public virtual Student Student { get; set; }
    public int SkillId { get; set; }
    public ICollection<Skill> Skills { get; set; }
}