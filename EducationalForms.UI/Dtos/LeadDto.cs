using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Domain.Enums;
using Domain.Models;
using Domain.Models.BaseModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EducationalForms.UI.Dtos;

public class LeadDto
{
    [Key]
    public int Id { get; set; }
    //[DisplayName("نام")]
    [Display(Name = "نام")]
    public string Name { get; set; }
    [Display(Name = "نام خانوادگی")]
    [DisplayName("نام خانوادگی")]
    public string Family { get; set; }
    [Display(Name = "جنسیت")]
    [DisplayName("جنسیت")]
    public GenderEnum Gender { get; set; }
    public DateTime CalledOn { get; set; }
    [Display(Name = "شیوه اشنایی")]
    [DisplayName("شیوه آشنایی")]
    public int? FamiliarityMethodId { get; set; }
    public virtual FamiliarityMethodDto? FamiliarityMethod { get; set; }
    [Display(Name = "موبایل")]
    [DisplayName("موبایل")]
    [StringLength(11)]
    public string CellPhone { get; set; }
    [Display(Name = "تلفن ثابت")]
    [DisplayName("تلفن ثابت")]
    [StringLength(10)]
    public string PhoneNumber { get; set; }
    [Display(Name = "مشاور")]
    [DisplayName("مشاور")]
    public int? ConsultantId { get; set; }
    public ConsultantDto? Consultant { get; set; }
    [Display(Name = "توضیحات")]
    [DisplayName("توضیحات")]
    public string Description { get; set; }
    [Display(Name = "دلیل شکست")]
    [DisplayName("دلیل شکست")]
    public int FailureReasonId { get; set; }

    public FailureReasonDto? FailureReason { get; set; }
    [Display(Name = "مهارت ها")]
    [DisplayName("مهارت ها")]
    public ICollection<LeadSkill> LeadSkills { get; set; }
    [Display(Name = "مهارت ها")]
    [DisplayName("مهارت ها")]
    public int[] LeadSkillIds { get; set; }

}