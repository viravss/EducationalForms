using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Domain.Enums;

namespace EducationalForms.UI.Dtos;

public class StudentDto
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "نام")]
    public string Name { get; set; }
    [Display(Name = "نام خانوادگی")]
    public string Family { get; set; }
    [Display(Name = "نام پدر")]
    public string FatherName { get; set; }
    [Display(Name = "جنسیت")]
    public GenderEnum Gender { get; set; }
    [Display(Name = "شهروند")]
    public string Citizen { get; set; }
    [Display(Name = "کد ملی")]
    [MaxLength(10)]
    public string NationalCode { get; set; }
    [Display(Name = "شماره شناسنامه")]
    public string IdentityNumber { get; set; }
    [Display(Name = "تاریخ تولد")]
    public DateTime BirthDate { get; set; }

    public DateDto BirthDateDto { get; set; }

    [Display(Name = "وضعیت پورتال")]
    public bool PortalStatus { get; set; }
    [Display(Name = "توضیحات")]
    public string Description { get; set; }
    [Display(Name = "عکس")]
    public string PhotoAddress { get; set; }
    [Display(Name = "محل تولد")]
    public string PlaceOfIssued { get; set; }
    public DateDto CreatedOnDto { get; set; }
    [Display(Name = "تاریخ ثبت نام")]
    public DateTime RegisterTime { get; set; }
    public DateTime ModifyOn { get; set; }
    [Display(Name = "وضعیت تاهل")]
    public MaritalStatusEnum MaritalStatus { get; set; }
    [Display(Name = "شیوه آشنایی")]
    public int FamiliarityMethodId { get; set; }
    public FamiliarityMethodDto FamiliarityMethod { get; set; }
    [Display(Name = "مشاور")]
    public int ConsultantId { get; set; }
    public ConsultantDto Consultant { get; set; }
    [Display(Name = "موبایل")]
    [MaxLength(11)]
    public string CellPhone { get; set; }
    [Display(Name = "تلفن ثابت")]
    [MaxLength(10)]
    public string PhoneNumber { get; set; }

    [Display(Name = "کد شهر")]
    [DisplayName("کد شهر")]
    [MaxLength(3)]
    public string CityCode { get; set; }

    [Display(Name = "شماره واتساپ")]
    public string WhatsAppNumber { get; set; }
    public ICollection<StudentServiceDto> StudentServices { get; set; }
    public ICollection<StudentSkillDto> StudentSkills { get; set; }
    [Display(Name = "مهارت ها")]
    public int[] StudentSkillIds { get; set; }
    [Display(Name = "سرویس ها")]
    public int[] StudentServiceIds { get; set; }

}

public class DateDto
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }

    public DateTime ConvertedDateTime
    {
        get
        {
            var persianCalendar = new PersianCalendar();
            return persianCalendar.ToDateTime(Year, Month, Day, 00, 00, 00, 00);
        }
    }
}