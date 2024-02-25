using VendingMachine.Repository;

namespace VendingMachine.Services
{
    public class DrinkElementsRenderer : IElementsRenderer
    {
        public IngredientsList GetIngredients()
        {
            return new DrinkIngredientsList();
        }

        public RecipesList GetRecipes()
        {
            return new DrinkRecipesList();
        }
    }
}
