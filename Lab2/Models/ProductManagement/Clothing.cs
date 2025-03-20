namespace Lab2.Models.ProductManagement
{
    // The Clothing class inherits from the Product base class.
    // It represents a specific type of product with its own shipping cost calculation.
    public class Clothing : Product
    {
        // Constructor: Calls the base class constructor to initialize name and weight.
        public Clothing(string name, double weight) : base(name, weight)
        {
        }

        // Overrides the abstract method from the Product class to provide a specific shipping cost calculation.
        public override double calculateShippingCost()
        {
            return m_weight * 2;
        }
    }
}
