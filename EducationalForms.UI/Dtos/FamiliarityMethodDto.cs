using System.ComponentModel.DataAnnotations;
using Domain.Models.BaseModel;

namespace EducationalForms.UI.Dtos;

public class FamiliarityMethodDto
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }


}