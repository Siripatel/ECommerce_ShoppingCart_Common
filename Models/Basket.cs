namespace ECommerce_ShoppingCart_Common.Models
{
    public partial class Basket
    {
        public int BId { get; set; }
        public string BTitle { get; set; } = null!;
        public string BImage { get; set; } = null!;
        public decimal BPrice { get; set; }
        public decimal BRating { get; set; }
    }
}
