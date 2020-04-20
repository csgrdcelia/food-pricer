using FoodPricer.Core.Order.Beverage;
using FoodPricer.Core.Order.Dessert;
using FoodPricer.Core.Order.Meal;
using FoodPricer.Core.Order.MealPlan;

namespace FoodPricer.Core.Order.Offer.MealPlan
{
    public class PlateMaxMealPlan : IMealPlan
    {
        public double Price => 21;
        
        public bool IsEligible(Order order)
        {
            return order.Meal is Plate && order.Beverage is LargeBeverage && order.Dessert is NormalDessert;
        }
    }
}