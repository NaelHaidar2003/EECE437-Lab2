namespace Lab2.Models.ProductManagement
{
    // Base class representing a generic product.
    public abstract class Product
    {
        public string m_name { get; set; }
        public double m_weight { get; set; }

        // Constructor: Initializes a product with a name and weight.
        public Product(string name, double weight)
        {
            m_name = name;
            m_weight = weight;
        }

        // Abstract method that must be implemented by derived classes to calculate the shipping cost.
        public abstract double calculateShippingCost();
    }
}
// The Product class is open for extension but closed for modification.
//Instead of modifying the Product class when adding new product types, we extend it by creating new subclasses (like Furniture).