using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FoodPricer.Core.Order.Offer.MealPlan;

namespace FoodPricer.Core.Order.MealPlan.Service
{
    public class MealPlanService
    {
        public IMealPlan GetMealPlanOrDefault(Order order)
        {
            return GetMealPlans().FirstOrDefault(mealPlan => mealPlan.IsEligible(order));
        }
            
        private IList<IMealPlan> GetMealPlans()
        {
            return new List<IMealPlan>()
            {
                new PlateStandardMealPlan(),
                new PlateMaxMealPlan(),
                new SandwichStandardMealPlan(),
                new SandwichMaxMealPlan()
            };
        }
    }
}