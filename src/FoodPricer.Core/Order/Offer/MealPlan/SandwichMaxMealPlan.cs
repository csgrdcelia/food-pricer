using FoodPricer.Core.Order.Beverage;
using FoodPricer.Core.Order.Dessert;
using FoodPricer.Core.Order.Meal;
using FoodPricer.Core.Order.MealPlan;

namespace FoodPricer.Core.Order.Offer.MealPlan
{
    public class SandwichMaxMealPlan : IMealPlan
    {
        public double Price => 16;
        
        public bool IsEligible(Order order)
        {
            return order.Meal is Sandwich && order.Beverage is LargeBeverage && order.Dessert is SpecialDessert;
        }
    }
}