using System.ComponentModel.DataAnnotations;

namespace DotnetTemplate.ApplicationService.ViewModels {
    public class UserRegistrationRequestVM {

        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public Role Role { get; set; }
    }

    public enum Role {
        Diarist = 1,
        Contractor = 2
    }
}
