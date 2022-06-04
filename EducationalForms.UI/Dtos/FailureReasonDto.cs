using System.ComponentModel.DataAnnotations;

namespace EducationalForms.UI.Dtos
{
    public class FailureReasonDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }


    }
}