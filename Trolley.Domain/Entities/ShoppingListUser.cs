namespace Trolley.Domain.Entities
{
    public class ShoppingListUser
    {

        public Guid ShoppingListId { get; set; }
        public ShoppingList ShoppingList { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
