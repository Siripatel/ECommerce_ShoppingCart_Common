using ECommerce_ShoppingCart_Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ECommerce_ShoppingCart_Common.Models
{
    public partial class RegisterUser
    {
        [Required(ErrorMessage = "Enter your Suffix")]
        [EnumDataType(typeof(SuffixEnum))]
        [JsonConverter(typeof(StringEnumConverter))]
        public SuffixEnum Suffix { get; set; }

        [Required(ErrorMessage = "Enter your Username")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Enter your FirstName")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Enter your LastName")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Enter your GovtIdentity")]
        [EnumDataType(typeof(GovtIdentityEnum))]
        [JsonConverter(typeof(StringEnumConverter))]
        public GovtIdentityEnum GovtIdentity { get; set; }

        [Required(ErrorMessage = "Enter your GovtIdentityNumber")]
        public string? GovtIdentityNumber { get; set; } = ""; 

        [Required(ErrorMessage = "Enter your PhoneNumberCountryCode")]
        [EnumDataType(typeof(NumberCountryCodeEnum))]
        [JsonConverter(typeof(StringEnumConverter))]
        public NumberCountryCodeEnum PhoneNumberCountryCode { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid PhoneNumber.")]
        public string? PhoneNumber { get; set; } = ""; 

        [RegularExpression(".+@..+")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid Email Id.")]
        [Required(ErrorMessage = "Enter your Email Id")]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string? Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }

        [NotMapped]
        public string? Role { get; set; }

        public bool ActiveFlag { get; set; }
    }
}
