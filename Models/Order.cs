using System.Text.Json.Serialization;

namespace ECommerce_ShoppingCart_Common.Models
{
    public partial class Order
    {
        public Order()
        {
            CartItems = new HashSet<CartItem>();
        }
        public int OId { get; set; }
        public int PId { get; set; }
        public string ODescription { get; set; } = null!;
        public DateTime DeliveryDate { get; set; }
        public string DeliveryAddress { get; set; } = null!;
        public string ContactInfo { get; set; } = null!;
        public string Status { get; set; } = null!;
        [JsonIgnore]
        public bool IsActive { get; set; }
        [JsonIgnore]
        public string CreatedBy { get; set; } = null!;
        [JsonIgnore]
        public DateTime CreatedDate { get; set; }
        [JsonIgnore]
        public string? ModifiedBy { get; set; }
        [JsonIgnore]
        public DateTime? ModofiedDate { get; set; }
        [JsonIgnore]
        public virtual Product PIdNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
