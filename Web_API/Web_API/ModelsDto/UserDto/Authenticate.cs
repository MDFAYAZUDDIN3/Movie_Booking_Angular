using System.ComponentModel.DataAnnotations;

namespace Web_API.ModelsDto.UserDto
{
    public class Authenticate
    {

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
