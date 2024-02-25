using Microsoft.AspNetCore.Mvc.Rendering;
using VendingMachine.Repository;

namespace VendingMachine.ViewComponents.Prices
{
    public class DrinkPriceCalculator
    {
        public List<SelectListItem> RecipesList { get; set; }
        public string SelectedRecipe { get; set; }
        public double? SelectedRecipePrice { get; set; }

        public DrinkPriceCalculator() { }
        public DrinkPriceCalculator(IEnumerable<string> recipesList, 
            string? selectedRecipe = null, 
            double? selectedRecipePrice = null)
        {
            SelectedRecipe = selectedRecipe ?? string.Empty;
            SelectedRecipePrice = selectedRecipePrice;
            RecipesList = new List<SelectListItem>();
            foreach (var recipe in recipesList)
            {
                RecipesList.Add(new SelectListItem(recipe, recipe));
            }
        }
    }
}
