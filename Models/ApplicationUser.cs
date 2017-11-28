using Microsoft.AspNetCore.Identity;

namespace AspNetCore203.Models {
    public class ApplicationUser : IdentityUser {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}