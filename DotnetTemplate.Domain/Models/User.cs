using DotnetTemplate.Domain.Models.Base;
using Microsoft.AspNetCore.Identity;

namespace DotnetTemplate.Domain.Models {
    public class User : IdentityUser {

        public string Role { get; set; }
    }
}
