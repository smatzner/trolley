namespace Trolley.Domain.Entities
{
    public class ShoppingList : BaseEntity
    {
        public string Name { get; set; }
        public bool IsCheapest { get; set; }

        // Navigation properties
        public ICollection<ProductShoppingList> ProductShoppingLists { get; set; }
        public ICollection<ShoppingListUser> ShoppingListUsers { get; set; }

    }
}
