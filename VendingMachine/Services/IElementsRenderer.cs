using VendingMachine.Repository;

namespace VendingMachine.Services
{
    public interface IElementsRenderer
    {
        IngredientsList GetIngredients();
        RecipesList GetRecipes();
    }
}
