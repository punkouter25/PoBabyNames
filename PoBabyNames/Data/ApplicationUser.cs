using Microsoft.AspNetCore.Identity;

namespace PoBabyNames.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int? GroupId { get; set; }  // Nullable if not all users are required to have a GroupId
    }

}
