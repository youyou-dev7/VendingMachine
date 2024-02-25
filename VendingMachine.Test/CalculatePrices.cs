using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using VendingMachine.Repository;
using VendingMachine.Services;

namespace VendingMachine.Test
{
    public class Tests
    {

        [Test]
        public void CalculatePrice_ShouldBeTheRightResult()
        {
            //arrange
            CalculateDrinkPrice calculateDrinkPrice = new CalculateDrinkPrice();
            DrinkIngredientsList ingredientsList = new DrinkIngredientsList();
            DrinkRecipesList recipesList = new DrinkRecipesList();

            //act
            var result = calculateDrinkPrice.Calculate("Expresso", 0.3, recipesList, ingredientsList);

            //assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1.56, result);
        }

        [Test]
        public void CalculatePrice_RecipeDoesNotExist()
        {
            //arrange
            CalculateDrinkPrice calculateDrinkPrice = new CalculateDrinkPrice();
            DrinkIngredientsList ingredientsList = new DrinkIngredientsList();
            DrinkRecipesList recipesList = new DrinkRecipesList();
            var expectedExcetpion = new NullReferenceException();

            //act
            var result = Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException<NullReferenceException>(() => calculateDrinkPrice.Calculate("", 0.3, recipesList, ingredientsList));

            //assert
            
            // Act & Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedExcetpion, result);
        }
    }
}