namespace Lab2.Models.ProductManagement
{
    public abstract class Product
    {
        public string m_name { get; set; }
        public double m_weight { get; set; }

        public Product(string name, double weight)
        {
            m_name = name;
            m_weight = weight;
        }
        public abstract double calculateShippingCost();
        
    }
}