using System.ComponentModel.DataAnnotations;

namespace DotnetTemplate.ApplicationService.ViewModels {
    public class UserLoginRequest {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
