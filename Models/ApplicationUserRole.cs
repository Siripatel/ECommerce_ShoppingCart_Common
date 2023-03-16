using ECommerce_ShoppingCart_DAL.DbContext;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_ShoppingCart_Common.Models
{
    public class ApplicationUserRole : IdentityUserRole<Guid>
    {
        [Required]
        public bool ActiveFlag { get; set; }
        public string? CreatedBy { get; set; } = "";
        public string? UpdatedBy { get; set; } = "";
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual ApplicationUser? User { get; set; }
        public virtual ApplicationRole? Role { get; set; }
    }
}
