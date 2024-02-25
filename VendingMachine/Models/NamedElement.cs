namespace VendingMachine.Models
{
    public abstract class NamedElement
    {
        private string _name;

        public string Name { get { return _name; } }

        public NamedElement (string name)
        {
            _name = name;
        }
    }
}
