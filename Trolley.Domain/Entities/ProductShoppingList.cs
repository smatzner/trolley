namespace Trolley.Domain.Entities
{
    public class ProductShoppingList
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid ShoppingListId { get; set; }
        public ShoppingList ShoppingList { get; set; }
    }
}
