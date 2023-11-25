namespace Trolley.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<BrandProduct> BrandProducts { get; set; }
    }
}
