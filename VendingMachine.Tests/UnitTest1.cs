using VendingMachine.Repository;
using VendingMachine.Services;

namespace VendingMachine.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculatePrice_ShouldBeTheRightResult()
        {
            //arrange
            CalculateDrinkPrice calculateDrinkPrice = new CalculateDrinkPrice();
            DrinkIngredientsList ingredientsList = new DrinkIngredientsList();
            DrinkRecipesList recipesList = new DrinkRecipesList();

            //act
            var result = calculateDrinkPrice.Calculate("Expresso", 0.3, recipesList, ingredientsList);

            //assert
            Assert.Equal(1.56, result);
        }
    }
}