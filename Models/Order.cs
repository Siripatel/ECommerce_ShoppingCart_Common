using System.Text.Json.Serialization;

namespace ECommerce_ShoppingCart_Common.Models
{
    public partial class Order
    {
        public int OId { get; set; }
        public int CId { get; set; }
        public string ODescription { get; set; } = null!;
        public DateTime DeliveryDate { get; set; }
        public string DeliveryAddress { get; set; } = null!;
        public string ContactInfo { get; set; } = null!;
        public string Status { get; set; } = null!;
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModofiedDate { get; set; }
    }
}
