using FoodPricer.Core.Order.Beverage;
using FoodPricer.Core.Order.Dessert;

namespace FoodPricer.Core.Order.MealPlan
{
    public class MaxMealPlan : IMealPlan
    {
        public double Price => 16;
        
        public bool IsEligible(Order order)
        {
            return order.Beverage is LargeBeverage && order.Dessert is SpecialDessert;
        }
    }
}