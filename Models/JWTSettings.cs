namespace ECommerce_ShoppingCart_Common.Models
{
    public class JWTSettings
    {
        public string? SecretKey { get; set; }
        public string? ValidAudience { get; set; }
        public string? ValidIssuer { get; set; }
        public double TokenValidityInMinutes { get; set; }
    }
}
