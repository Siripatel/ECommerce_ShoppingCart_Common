using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_ShoppingCart_Common.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole()
        { 
        }
        public ApplicationRole(string roleName) : base(roleName)
        { 
        }

        [Required]
        public bool ActiveFlag { get; set; }
        public string? CreatedBy { get; set; } = "";
        public string? UpdatedBy { get; set; } = "";
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual ICollection<ApplicationUserRole>? UserRoles { get; set; }
    }
}
