using Domain.Models.BaseModel;
namespace Domain.Models;
public class Consulting : BaseEntity
{
    //TODO skils relatoin 
    public Consulting()
    {

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