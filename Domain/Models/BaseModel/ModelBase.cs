using System.ComponentModel.DataAnnotations;

namespace Domain.Models.BaseModel;

public class ModelBase
{
    [Key]
    public int Id { get; set; }
    public DateTime RegisterDateTime { get; set; }
}