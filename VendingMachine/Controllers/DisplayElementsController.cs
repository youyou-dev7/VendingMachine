using Microsoft.AspNetCore.Mvc;
using VendingMachine.Services;
using VendingMachine.ViewComponents.Renderer;

namespace VendingMachine.Controllers
{
    public class DisplayElementsController : Controller
    {

        private readonly IElementsRenderer _elementsRenderer;

        public DisplayElementsController(IElementsRenderer elementsRenderer)
        {
            _elementsRenderer = elementsRenderer;
        }

        public IActionResult DisplayRecipes()
        {
            RecipesRenderer recipes = new RecipesRenderer((Repository.DrinkRecipesList)_elementsRenderer.GetRecipes());

            return View(recipes);
        }
        public IActionResult DisplayIngredients()
        {
            IngredientsRenderer ingredients = new IngredientsRenderer((Repository.DrinkIngredientsList)_elementsRenderer.GetIngredients());

            return View(ingredients);
        }
    }
}
