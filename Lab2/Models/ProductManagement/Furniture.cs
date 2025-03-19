namespace  Lab2.Models.ProductManagement
{
    public class Furniture : Product
    {
        public Furniture(string name, double weight) : base(name, weight)
        {
        }

        public override double calculateShippingCost()
        {
            return m_weight * 3;
        }
    }
}