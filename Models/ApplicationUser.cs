using ECommerce_ShoppingCart_Common.Enums;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_ShoppingCart_DAL.DbContext
{
    public partial class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        { 
        }

        [Required(ErrorMessage = "Enter your Suffix")]
        [EnumDataType(typeof(SuffixEnum))]
        [JsonConverter(typeof(StringEnumConverter))]
        public SuffixEnum Suffix { get; set; }

        [Required(ErrorMessage = "Enter your First Name")]
        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "Enter your Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Enter your GovtIdentity")]
        [EnumDataType(typeof(GovtIdentityEnum))]
        [JsonConverter(typeof(StringEnumConverter))]
        public GovtIdentityEnum GovtIdentity { get; set; }

        public string GovtIdentityNumber { get; set; } = "";

        [Required(ErrorMessage = "Enter your PhoneNumberCountryCode")]
        [EnumDataType(typeof(NumberCountryCodeEnum))]
        [JsonConverter(typeof(StringEnumConverter))]
        public NumberCountryCodeEnum PhoneNumberCountryCode { get; set; }

        [Required]
        [JsonIgnore]
        public bool ActiveFlag { get; set; }
        [JsonIgnore]
        public string? CreatedBy { get; set; } = "";
        [JsonIgnore]
        public string? UpdatedBy { get; set; } = "";
        [JsonIgnore]
        public DateTime? CreatedDate { get; set; }
        [JsonIgnore]
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<IdentityUserClaim<Guid>>? Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<Guid>>? Logins { get; set; }
        public virtual ICollection<IdentityUserToken<Guid>>? Tokens { get; set; }
        public virtual ICollection<IdentityUserRole<Guid>>? UserRoles { get; set; }
    }
}
