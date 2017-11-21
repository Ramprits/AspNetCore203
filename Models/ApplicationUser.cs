using Microsoft.AspNetCore.Identity;

namespace AspNet_core_203.Models {
    public class ApplicationUser : IdentityUser {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}