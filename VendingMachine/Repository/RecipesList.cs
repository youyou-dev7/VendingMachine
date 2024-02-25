using VendingMachine.Models;

namespace VendingMachine.Repository
{
    public abstract class RecipesList
    {
        public IEnumerable<Recipe> Recipes { get; protected set; }
    }
}
