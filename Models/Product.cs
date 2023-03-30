using System.Text.Json.Serialization;

namespace ECommerce_ShoppingCart_Common.Models
{
    public partial class Product
    {
        public int PId { get; set; }
        public string PSerialNumber { get; set; } = null!;
        public string PName { get; set; } = null!;
        public string PDescription { get; set; } = null!;
        public string PProductType { get; set; } = null!;
        public string PManufacturer { get; set; } = null!;
        public DateTime PProductionDate { get; set; }
        public decimal PPrice { get; set; }
        public string PCurrency { get; set; } = null!;
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
