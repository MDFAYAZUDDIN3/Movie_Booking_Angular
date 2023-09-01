using System.ComponentModel.DataAnnotations;

namespace Web_API.Models.User
{
    public class Authenticate
    { 

        [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}
}
