using System.Text.Json.Serialization;

namespace ECommerce_ShoppingCart_Common.Models
{
    public partial class CartItem
    {
        public int CId { get; set; }
        public int BId { get; set; }
        public string CDescription { get; set; } = null!;
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
