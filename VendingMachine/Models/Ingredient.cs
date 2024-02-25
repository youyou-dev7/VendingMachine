namespace VendingMachine.Models
{
    public class Ingredient : NamedElement
    {
        private readonly double _price;
        public double Price => _price;
        public Ingredient(string name, double price) : base(name)
        {
            _price = price;
        }
    }
}