using System.ComponentModel.DataAnnotations;

namespace EducationalForms.UI.Dtos;

public class SkillDto
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public long Price { get; set; }
    public int Time { get; set; }
    public ICollection<LeadSkillDto> LeadSkills { get; set; }
}