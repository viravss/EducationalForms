using System.ComponentModel.DataAnnotations;

namespace Domain.Models.BaseModel;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
    public DateTime RegisterDateTime { get; set; }
}