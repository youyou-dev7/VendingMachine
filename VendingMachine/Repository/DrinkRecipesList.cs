using VendingMachine.Models;

namespace VendingMachine.Repository
{
    public class DrinkRecipesList : RecipesList
    {
        public DrinkRecipesList() {
            Recipes = new List<Recipe> { new Recipe("Expresso", new List<string>() { "cafe", "eau" }),
                                         new Recipe("Allonge", new List<string>() { "cafe", "eau", "eau" }),
                                         new Recipe("Cacuccino", new List<string>() { "cafe", "chocolat", "eau", "creme" }),
                                         new Recipe("Chocolat", new List<string>() { "chocolat", "chocolat", "chocolat", "lait", "lait", "eau", "sucre" }),
                                         new Recipe("The", new List<string>() { "the", "eau", "eau" } )};
        }
    }
}
