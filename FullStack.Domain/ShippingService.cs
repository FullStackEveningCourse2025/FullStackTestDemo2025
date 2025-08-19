namespace FullStack.Domain
{
    public class ShippingService
    {
        public decimal Calculate(decimal subtotal, string country)
        {
            // if > 50, return 0 
            if (subtotal < 0) throw new ArgumentOutOfRangeException(nameof(subtotal));
            if (country == "IE") return 4.99m;
            return 9.99m;

        }
    }
}
