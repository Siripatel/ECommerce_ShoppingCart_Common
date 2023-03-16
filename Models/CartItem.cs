using System.Text.Json.Serialization;

namespace ECommerce_ShoppingCart_Common.Models
{
    public partial class CartItem
    {
        public int CId { get; set; }
        public int OId { get; set; }
        public string CClientId { get; set; } = null!;
        [JsonIgnore]
        public bool IsActive { get; set; }
        [JsonIgnore]
        public string CreatedBy { get; set; } = null!;
        [JsonIgnore]
        public DateTime CreatedDate { get; set; }
        [JsonIgnore]
        public string? ModifiedBy { get; set; }
        [JsonIgnore]
        public DateTime? ModifiedDate { get; set; }
        [JsonIgnore]
        public virtual Order OIdNavigation { get; set; } = null!;
    }
}
