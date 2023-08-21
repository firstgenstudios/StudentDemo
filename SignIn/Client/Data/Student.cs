using System.ComponentModel.DataAnnotations;

namespace SignIn.Client.Data
{
    public class Student
    {
        [Required]
        [StringLength(10, ErrorMessage = "Username is too long.")]
        public string? Username { get; set; } = null!;

        [Required]
        [StringLength(18, ErrorMessage = "Password is too long.")]
        public string? Password { get; set; } = null!;
    }
}
