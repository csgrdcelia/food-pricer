using FoodPricer.Core.Order.Beverage;
using FoodPricer.Core.Order.Dessert;
using FoodPricer.Core.Order.Meal;

namespace FoodPricer.Core.Order.Offer.Discount
{
    public class CoffeeDiscount : IDiscount
    {
        public int Reduction => 1;
        
        public bool IsEligible(Order order)
        {
            return order.WithCoffee && order.Meal is Plate && order.Beverage is MediumBeverage && order.Dessert is NormalDessert;
        }
    }
}