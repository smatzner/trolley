using Trolley.Domain.Enums;

namespace Trolley.Domain.Entities
{
    public class Market : BaseEntity
    {
        public string Name { get; set; }
        public bool IsNearest { get; set; }
        public MarketCategory Category { get; set; }

        // Navigation properties
        public ICollection<MarketProductPrice> MarketProductPrices { get; set; }

    }
}
