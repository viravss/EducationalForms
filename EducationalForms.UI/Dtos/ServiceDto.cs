using System.ComponentModel.DataAnnotations;

namespace EducationalForms.UI.Dtos;

public class ServiceDto
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}