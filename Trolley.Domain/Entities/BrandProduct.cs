namespace Trolley.Domain.Entities
{
    public class BrandProduct
    {
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
