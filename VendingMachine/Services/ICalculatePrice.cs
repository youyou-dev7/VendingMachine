using VendingMachine.Models;
using VendingMachine.Repository;

namespace VendingMachine.Services
{
    public interface ICalculatePrice
    {
        double Calculate(string recipe, double merginPercentage, RecipesList recipesList, IngredientsList ingredientsList);
    }
}
