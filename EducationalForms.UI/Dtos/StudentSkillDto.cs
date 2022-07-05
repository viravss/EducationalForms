using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace EducationalForms.UI.Dtos;

public class StudentSkillDto
{
    [Key]
    public int Id { get; set; }
    public int StudentId { get; set; }
    public virtual StudentDto Student { get; set; }
    public int SkillId { get; set; }
    public ICollection<SkillDto> Skills { get; set; }
}