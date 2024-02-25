using VendingMachine.Models;
using VendingMachine.Repository;

namespace VendingMachine.Services
{
    public class CalculateDrinkPrice : ICalculatePrice
    {
        private RecipesList _recipesList;
        private IngredientsList _ingredientsList;
        

        public double Calculate(string recipeName, double merginPercentage, RecipesList recipesList, IngredientsList ingredientsList)
        {
            if (!recipesList.Recipes.Any())
            {
                throw new NullReferenceException("There is no recipe");
            }
            _recipesList = recipesList;

            if (!ingredientsList.Ingredients.Any())
            {
                throw new NullReferenceException("There is no ingredient");
            }
            _ingredientsList = ingredientsList;

            if(recipeName == null || _recipesList.Recipes.FirstOrDefault(x => x.Name == recipeName) == null)
            {
                throw new NullReferenceException("recipe is null or does not exist");
            }
            try
            {
                return CalculatePriceWithMargin(_recipesList.Recipes.First(x => x.Name == recipeName), merginPercentage);
            }
            catch
            {
                throw;
            }
        }

        private double CalculatePriceWithMargin(Recipe recipe, double merginPercentage)
        {

            double price = 0;
            double percentage = merginPercentage;
            foreach(var ingredient in recipe.Ingredients)
            {
                if (_ingredientsList.Ingredients.FirstOrDefault(x =>  x.Name == ingredient) == null)
                {
                    throw new NullReferenceException($"{ingredient} does not exist");
                }
                price += _ingredientsList.Ingredients.First(x => x.Name == ingredient).Price;

            }

            return Math.Round(price * (1+percentage),2);
        }
    }
}
