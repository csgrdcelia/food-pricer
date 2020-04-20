using System;
using FoodPricer.Core.Order.Beverage;
using FoodPricer.Core.Order.Dessert;
using FoodPricer.Core.Order.Meal;
using FoodPricer.Core.Order.MealPlan;
using FoodPricer.Core.Order.MealPlan.Service;
using FoodPricer.Core.Order.Offer.Discount.Service;

namespace FoodPricer.Core.Order
{
    public class Order
    {
        public IMeal Meal { get; }
        public IBeverage Beverage { get; }
        public IDessert Dessert { get; }
        public bool WithCoffee { get; }

        public Order(IMeal meal, IBeverage beverage, IDessert dessert, bool withCoffee)
        {
            Meal = meal;
            Beverage = beverage;
            Dessert = dessert;
            WithCoffee = withCoffee;
        }

        public double GetPrice()
        {
            IMealPlan mealPlan = new MealPlanService().GetMealPlanOrDefault(this);
            double reduction = new DiscountService().GetOverallReduction(this);
            
            if (mealPlan != null)
            {
                return mealPlan.Price + (WithCoffee ? 1 : 0) - reduction;
            }
            
            return Meal.Price + Beverage.Price + Dessert.Price + (WithCoffee ? 1 : 0) - reduction;
        }
    }
}