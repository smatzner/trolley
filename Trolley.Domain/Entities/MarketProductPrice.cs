namespace Trolley.Domain.Entities
{
    public class MarketProductPrice
    {


        // Navigation Properties

        public Guid PriceId { get; set; }
        public virtual Price Price { get; set; }

        public Guid MarketId { get; set; }
        public virtual Market Market { get; set; }

        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
