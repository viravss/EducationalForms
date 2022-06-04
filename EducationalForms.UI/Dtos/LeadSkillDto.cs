using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace EducationalForms.UI.Dtos;

public class LeadSkillDto
{
    [Key]
    public int Id { get; set; }
    public int LeadId { get; set; }
    public virtual Lead Lead { get; set; }
    public ICollection<SkillDto> Skills { get; set; }
}