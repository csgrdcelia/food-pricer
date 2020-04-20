namespace FoodPricer.Core.Order.MealPlan
{
    public interface IMealPlan
    {
        double Price { get; }
        bool IsEligible(Order order);
    }
}