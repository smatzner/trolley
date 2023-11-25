namespace Trolley.Domain.Entities
{
    public class Price : BaseEntity
    {
        public double Amount { get; set; }
        public double? Reduction { get; set; }

        public DateTime Timestamp { get; set; }

        // Navigation properties
        public ICollection<MarketProductPrice> MarketProductPrices { get; set; }

    }
}
