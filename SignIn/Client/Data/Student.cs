using System.ComponentModel.DataAnnotations;

namespace SignIn.Client.Data
{
    public class Student
    {
        [Required]
        public string Firstname { get; set; } = null!;

        [Required]
        public string Lastname { get; set; } = null!;

        [Required]
        public string StudentId { get; set; } = null!;
    }
}
