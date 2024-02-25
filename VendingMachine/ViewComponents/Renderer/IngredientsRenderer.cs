using VendingMachine.Repository;

namespace VendingMachine.ViewComponents.Renderer
{
    public class IngredientsRenderer
    {
        public DrinkIngredientsList DrinkIngredientsList { get; set; }
        public IngredientsRenderer(DrinkIngredientsList ingredientsList)
        {
            DrinkIngredientsList = ingredientsList;
        }
    }
}
