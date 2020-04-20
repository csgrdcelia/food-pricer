using FoodPricer.Core.Order.Beverage;
using FoodPricer.Core.Order.Dessert;
using FoodPricer.Core.Order.Meal;
using FoodPricer.Core.Order.MealPlan;

namespace FoodPricer.Core.Order.Offer.MealPlan
{
    public class SandwichStandardMealPlan : IMealPlan
    {
        public double Price => 13;
        
        public bool IsEligible(Order order)
        {
            return order.Meal is Sandwich && order.Beverage is MediumBeverage && order.Dessert is NormalDessert;
        }
    }
}