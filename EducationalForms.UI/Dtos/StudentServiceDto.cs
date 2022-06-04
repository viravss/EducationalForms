using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace EducationalForms.UI.Dtos;

public class StudentServiceDto
{
    [Key]
    public int Id { get; set; }
    public int StudentId { get; set; }
    public virtual StudentDto Student { get; set; }
    public ICollection<ServiceDto> Services { get; set; }
}