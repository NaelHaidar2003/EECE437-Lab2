namespace Lab2.Models.ProductManagement
{
    public class Clothing : Product
    {
        public Clothing(string name, double weight) : base(name, weight)
        {
        }

        public override double calculateShippingCost()
        {
            return m_weight * 2;
        }
    }
}