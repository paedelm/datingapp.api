using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(24,MinimumLength = 2)]
        public string Username { get; set; }
        [Required]
        [StringLength(12,MinimumLength = 6, ErrorMessage = "minimum Passwordlength is 6 and the maximum is 12")]
        public string Password { get; set; }
    }
}