using System;
using FoodPricer.Core.Order;
using FoodPricer.Core.Order.Beverage;
using FoodPricer.Core.Order.Dessert;
using FoodPricer.Core.Order.Meal;
using Xunit;

namespace FoodPricer.Tests
{
    public class OrderTest
    {
        [Fact]
        public void Order_WithPlateStandardMealPlan_AndThereforeCoffeeDiscount_ShouldCost18()
        {
            Order order = new Order(new Plate(), new MediumBeverage(), new NormalDessert(), true);
            Assert.Equal(18, order.GetPrice());
        }
        
        [Fact]
        public void Order_WithSandwichStandardMealPlan_AndCoffee_ShouldCost14()
        {
            Order order = new Order(new Sandwich(), new MediumBeverage(), new NormalDessert(), true);
            Assert.Equal(14, order.GetPrice());
        }
        
        [Fact]
        public void Order_WithPlateMaxMealPlan_AndWithoutCoffee_ShouldCost21()
        {
            Order order = new Order(new Plate(), new LargeBeverage(), new NormalDessert(), false);
            Assert.Equal(21, order.GetPrice());
        }
        
        [Fact]
        public void Order_WithPlateMaxMealPlan_AndCoffee_ShouldCost22()
        {
            Order order = new Order(new Plate(), new LargeBeverage(), new NormalDessert(), true);
            Assert.Equal(22, order.GetPrice());
        }
        
        [Fact]
        public void Order_WithSandwichMaxMealPlan_AndCoffee_ShouldCost17()
        {
            Order order = new Order(new Plate(), new LargeBeverage(), new NormalDessert(), true);
            Assert.Equal(22, order.GetPrice());
        }
        
        [Fact]
        public void Order_WithSandwich_NoMealPlanOrDiscount_AndWithCoffee_ShouldCost17()
        {
            Order order = new Order(new Sandwich(), new LargeBeverage(), new NormalDessert(), true);
            Assert.Equal(17, order.GetPrice());
        }
        
        [Fact]
        public void Order_WithSandwich_NoMealPlanOrDiscount_WithoutCoffee_ShouldCost16()
        {
            Order order = new Order(new Sandwich(), new LargeBeverage(), new NormalDessert(), false);
            Assert.Equal(16, order.GetPrice());
        }
    }
}
