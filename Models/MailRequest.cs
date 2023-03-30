using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;

namespace ECommerce_ShoppingCart_Common.Models
{
    public class MailRequest
    {
        public int Id { get; set; }
        public string? ToEmail { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        [JsonIgnore]
        public bool? IsActive { get; set; }
        //public List<IFormFile> Attachments { get; set; }
    }
}
