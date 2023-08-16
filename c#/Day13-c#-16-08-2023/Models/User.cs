using System.ComponentModel.DataAnnotations;

namespace JWT_Auth.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Email { get; set; }

        public string Role { get; set; } = string.Empty;
    }
}
