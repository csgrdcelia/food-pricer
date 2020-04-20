using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FoodPricer.Core.Order.MealPlan;

namespace FoodPricer.Core.Order.Offer.Discount.Service
{
    public class DiscountService
    {
        public double GetOverallReduction(Order order)
        {
            return GetEligibleDiscounts(order).Sum(discount => discount.Reduction);
        }
        
        private IList<IDiscount> GetEligibleDiscounts(Order order)
        {
            return GetDiscounts().Where(discount => discount.IsEligible(order)).ToList();
        }
        
        private IList<IDiscount> GetDiscounts()
        {
            return new List<IDiscount>()
            {
                new CoffeeDiscount()
            };
        }
    }
}