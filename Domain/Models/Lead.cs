using System.ComponentModel.DataAnnotations;
using Domain.Enums;
using Domain.Models.BaseModel;

namespace Domain.Models;

public class Lead : BaseEntity
{
    public Lead()
    {
        LeadSkills = new HashSet<LeadSkill>();
    }
    public string Name { get; set; }
    public string Family { get; set; }
    public GenderEnum Gender { get; set; }
    public DateTime CalledOn { get; set; }
    public int? FamiliarityMethodId { get; set; }
    public virtual FamiliarityMethod? FamiliarityMethod { get; set; }
    [StringLength(11)]
    public string CellPhone { get; set; }
    [StringLength(10)]
    public string PhoneNumber { get; set; }
    public int? ConsultantId { get; set; }
    public Consultant? Consultant { get; set; }
    public string Description { get; set; }
    public int FailureReasonId { get; set; }
    public FailureReason? FailureReason { get; set; }
    public ICollection<LeadSkill> LeadSkills { get; set; }
}