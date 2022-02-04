using Domain.Models.BaseModel;
namespace Domain.Models;
public class Consulting : ModelBase
{
    //TODO skils relatoin 
    public Consulting(string firstName, string lastName, bool gender, DateTime callDateTime, int introductionId, string cellPhone, string phone, int consultantId, DateTime nextFollowUpDate, int status, string followUpDescription)
    {
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        CallDateTime = callDateTime;
        IntroductionId = introductionId;
        CellPhone = cellPhone;
        Phone = phone;
        ConsultantId = consultantId;
        NextFollowUpDate = nextFollowUpDate;
        Status = status;
        FollowUpDescription = followUpDescription;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool Gender { get; set; }
    public DateTime CallDateTime { get; set; }
    public int IntroductionId { get; set; } //TODO create relation 
    public string CellPhone { get; set; }
    public string Phone { get; set; }
    public int ConsultantId { get; set; } //TODO create relation 
    //public int TypeOfRegister { get; set; }////TODO create relation 
    public DateTime NextFollowUpDate { get; set; }
    /// <summary>
    /// status of register
    /// </summary>
    public int Status { get; set; }
    public string FollowUpDescription { get; set; }
}