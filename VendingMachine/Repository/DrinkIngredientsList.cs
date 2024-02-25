using System.Runtime.CompilerServices;
using VendingMachine.Models;

namespace VendingMachine.Repository
{
    public class DrinkIngredientsList:IngredientsList
    {
        public DrinkIngredientsList() {
            Ingredients = new List<Ingredient> { new Ingredient("cafe", 1),
new Ingredient("sucre", 0.1),
new Ingredient("creme", 0.5),
new Ingredient("the", 2),
new Ingredient("eau", 0.2),
new Ingredient("chocolat", 1),
new Ingredient("lait", 0.4), };
        }
    }
}
