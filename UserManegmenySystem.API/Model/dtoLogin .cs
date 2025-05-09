using System.ComponentModel.DataAnnotations;

namespace UserManegmenySystem.API.Model
{
    public class dtoLogin
    {
        [Required]
        public string userName {  get; set; }

        [Required]
        public string password { get; set; }

    }
}
