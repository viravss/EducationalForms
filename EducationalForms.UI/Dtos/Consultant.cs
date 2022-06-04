using System.ComponentModel.DataAnnotations;

namespace EducationalForms.UI.Dtos;

public class ConsultantDto
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public bool IsActive { get; set; }

}