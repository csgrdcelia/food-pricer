namespace FoodPricer.Core.Order.Offer.Discount
{
    public interface IDiscount
    {
        int Reduction { get; }
        bool IsEligible(Order order);
    }
}