using System.ComponentModel.DataAnnotations;
using Domain.Enums;
using Domain.Models.BaseModel;

namespace Domain.Models;

public class Student : BaseEntity
{
    public Student()
    {
        StudentServices = new HashSet<StudentService>();
        StudentSkills = new HashSet<StudentSkill>();
    }
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
    public MaritalStatusEnum MaritalStatus { get; set; }
    public int FamiliarityMethodId { get; set; }
    public FamiliarityMethod FamiliarityMethod { get; set; }
    public int ConsultantId { get; set; }
    public Consultant Consultant { get; set; }
    [MaxLength(11)]
    public string CellPhone { get; set; }
    [MaxLength(10)]
    public string PhoneNumber { get; set; }
    public string WhatsAppNumber { get; set; }
    public ICollection<StudentService> StudentServices { get; set; }
    public ICollection<StudentSkill> StudentSkills { get; set; }

}