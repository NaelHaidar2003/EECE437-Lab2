
namespace Lab2.Models.ProductManagement
{
    public class Electronics : Product
    {
        public Electronics(string name, double weight) : base(name, weight)
        {
        }
        public override double calculateShippingCost()
        {
            return m_weight * 4;
        }
    }
}