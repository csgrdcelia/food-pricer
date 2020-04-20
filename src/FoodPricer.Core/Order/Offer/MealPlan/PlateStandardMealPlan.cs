using FoodPricer.Core.Order.Beverage;
using FoodPricer.Core.Order.Dessert;
using FoodPricer.Core.Order.Meal;
using FoodPricer.Core.Order.MealPlan;

namespace FoodPricer.Core.Order.Offer.MealPlan
{
    public class PlateStandardMealPlan : IMealPlan
    {
        public double Price => 18;
        
        public bool IsEligible(Order order)
        {
            return order.Meal is Plate && order.Beverage is MediumBeverage && order.Dessert is NormalDessert;
        }
    }
}