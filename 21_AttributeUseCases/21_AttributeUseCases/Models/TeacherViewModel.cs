using System.ComponentModel.DataAnnotations;

namespace _21_AttributeUseCases.Models
{
    public class TeacherViewModel
    {
        [Required]
        [Display(Name = "Teacher Id")]
        public int Id { get; set; }
    }
}
