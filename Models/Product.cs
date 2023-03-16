using System.Text.Json.Serialization;

namespace ECommerce_ShoppingCart_Common.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int PId { get; set; }
        public string PSerialNumber { get; set; } = null!;
        public string PName { get; set; } = null!;
        public string PDescription { get; set; } = null!;
        public string PProductType { get; set; } = null!;
        public string PManufacturer { get; set; } = null!;
        public DateTime PProductionDate { get; set; }
        public decimal PPrice { get; set; }
        public string PCurrency { get; set; } = null!;
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
        public virtual ICollection<Order> Orders { get; set; }
    }
}
