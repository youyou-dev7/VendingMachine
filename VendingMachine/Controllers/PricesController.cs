using Microsoft.AspNetCore.Mvc;
using VendingMachine.Services;
using VendingMachine.ViewComponents.Prices;

namespace VendingMachine.Controllers
{
    public class PricesController: Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculatePrice _calculatePrice;
        private readonly IElementsRenderer _elementsRenderer;
        private const double DEFAULT_MARGIN_PERCENTAGE = 0.3;

        public PricesController(ILogger<HomeController> logger,
            ICalculatePrice calculatePrice,
            IElementsRenderer elementsRenderer)
        {
            _logger = logger;
            _calculatePrice = calculatePrice;
            _elementsRenderer = elementsRenderer;
        }

        public IActionResult SellPriceForDrinks()
        {
            DrinkPriceCalculator drinkPriceCalculator =
                new DrinkPriceCalculator(_elementsRenderer.GetRecipes().Recipes.Select(r => r.Name).ToList());
            return View("SellPriceForDrinks", drinkPriceCalculator);
        }

        [HttpPost]
        public IActionResult SellPriceForDrinks(DrinkPriceCalculator model)
        {
            try
            {
                DrinkPriceCalculator result = new DrinkPriceCalculator(_elementsRenderer.GetRecipes().Recipes.Select(r => r.Name).ToList(),
                    model.SelectedRecipe,
                    _calculatePrice.Calculate(model.SelectedRecipe, DEFAULT_MARGIN_PERCENTAGE,
                        _elementsRenderer.GetRecipes(), _elementsRenderer.GetIngredients()));
                return View(result);
            }
            catch
            {
                throw;
            }
        }

    }
}
