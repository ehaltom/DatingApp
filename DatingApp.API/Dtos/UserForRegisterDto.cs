using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]

        public string Username { get; set; }

        [Required]
        [StringLength(10, MinimumLength=6,ErrorMessage="Password should contain six to ten characters.")]
        public string Password { get; set; }
    }
}