using System.ComponentModel.DataAnnotations;

namespace UserManegmenySystem.API.Model
{
    public class DtoAppUser
    {
        [Required]       
        public string usrename { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public string? phoneNumber { get; set; }
    }
}
