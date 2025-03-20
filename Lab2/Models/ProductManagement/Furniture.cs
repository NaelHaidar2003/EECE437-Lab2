namespace Lab2.Models.ProductManagement
{
    // The Furniture class inherits from the Product base class.
    // It represents a specific type of product with its own shipping cost calculation.
    public class Furniture : Product
    {
        // Constructor: Calls the base class constructor to initialize name and weight.
        public Furniture(string name, double weight) : base(name, weight)
        {
        }

        // Overrides the abstract method from the Product class to provide a specific shipping cost calculation.
        public override double calculateShippingCost()
        {
            return m_weight * 3;
        }
    }
}
