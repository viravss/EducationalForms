using System.ComponentModel.DataAnnotations;
using Domain.Enums;
using Domain.Models;
using Domain.Models.BaseModel;

namespace EducationalForms.UI.Dtos;

public class LeadDto
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public GenderEnum Gender { get; set; }
    public DateTime CalledOn { get; set; }
    public int? FamiliarityMethodId { get; set; }
    public virtual FamiliarityMethodDto? FamiliarityMethod { get; set; }
    [StringLength(11)]
    public string CellPhone { get; set; }
    [StringLength(10)]
    public string PhoneNumber { get; set; }
    public int? ConsultantId { get; set; }
    public ConsultantDto? Consultant { get; set; }
    public string Description { get; set; }
    public DateTime CreateOn { get; set; }
    public DateTime ModifyOn { get; set; }
    public int FailureReasonId { get; set; }

    public FailureReasonDto? FailureReason { get; set; }
    public ICollection<LeadSkillDto> LeadSkills { get; set; }
}