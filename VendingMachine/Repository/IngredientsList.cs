using VendingMachine.Models;

namespace VendingMachine.Repository
{
    public abstract class IngredientsList
    {
        public IEnumerable<Ingredient> Ingredients { get; protected set; }
    }
}
