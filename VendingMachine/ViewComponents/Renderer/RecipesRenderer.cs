using VendingMachine.Repository;

namespace VendingMachine.ViewComponents.Renderer
{
    public class RecipesRenderer
    {

        public Dictionary<string, string> DrinkRecipesList { get; set; }
        public RecipesRenderer(DrinkRecipesList recipesList)
        {
            DrinkRecipesList = new Dictionary<string, string>();
            foreach (var recipe in recipesList.Recipes)
            {
                DrinkRecipesList.Add(recipe.Name, string.Join(", ", recipe.Ingredients));
            }
        }
    }
}
