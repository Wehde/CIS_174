using System.ComponentModel.DataAnnotations;

namespace Week6.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter a grade.")]
        public string? Grade { get; set; }
    }
}
