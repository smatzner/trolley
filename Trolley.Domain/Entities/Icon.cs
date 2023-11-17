namespace Trolley.Domain.Entities
{
    public class Icon : BaseEntity
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public virtual Category Category { get; set; }
    }
}
