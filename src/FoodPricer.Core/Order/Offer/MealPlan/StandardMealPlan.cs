using FoodPricer.Core.Order.Beverage;
using FoodPricer.Core.Order.Dessert;

namespace FoodPricer.Core.Order.MealPlan
{
    public class StandardMealPlan : IMealPlan
    {
        public double Price => 18;
        
        public bool IsEligible(Order order)
        {
            return order.Beverage is MediumBeverage && order.Dessert is NormalDessert;
        }
    }
}