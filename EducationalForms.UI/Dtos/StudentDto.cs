using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace EducationalForms.UI.Dtos;

public class StudentDto
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string FatherName { get; set; }
    public GenderEnum Gender { get; set; }
    public string Citizen { get; set; }
    [MaxLength(10)]
    public string NationalCode { get; set; }
    public string IdentityNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public bool PortalStatus { get; set; }
    public string Description { get; set; }
    public string PhotoAddress { get; set; }
    public string PlaceOfIssued { get; set; }
    public DateTime CreateOn { get; set; }
    public DateTime ModifyOn { get; set; }
    public MaritalStatusEnum MaritalStatus { get; set; }
    public int FamiliarityMethodId { get; set; }
    public FamiliarityMethodDto FamiliarityMethod { get; set; }
    public int ConsultantId { get; set; }
    public ConsultantDto Consultant { get; set; }
    [MaxLength(11)]
    public string CellPhone { get; set; }
    [MaxLength(10)]
    public string PhoneNumber { get; set; }
    public string WhatsAppNumber { get; set; }
    public ICollection<StudentServiceDto> StudentServices { get; set; }
    public ICollection<StudentSkillDto> StudentSkills { get; set; }

}