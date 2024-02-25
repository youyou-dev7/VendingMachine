using System.Collections;

namespace VendingMachine.Models
{
    public class Recipe : NamedElement
    {
        private IEnumerable<string> _ingredients;
        public IEnumerable<string> Ingredients => _ingredients;
        public Recipe(string name, IEnumerable<string> ingredients) : base(name)
        {
            _ingredients = ingredients;
        }
    }
}
