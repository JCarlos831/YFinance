using Microsoft.AspNetCore.Identity;

namespace YFinance.Models
{
    public class ManageUsersViewModel
    {
        public IdentityUser[] Administrators { get; set; }
        
        public IdentityUser[] Everyone { get; set; }
    }
}