using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Skill
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
}