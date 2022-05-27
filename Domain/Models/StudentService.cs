using Domain.Models.BaseModel;

namespace Domain.Models;

public class StudentService : IdentityBaseEntity
{
    public StudentService()
    {
        Services = new HashSet<Service>();
    }
    public int StudentId { get; set; }
    public virtual Student Student { get; set; }
    public ICollection<Service> Services { get; set; }
}