using System;
namespace PizzaStore
{
    public class NYStylePizzaStore:PizzaStore
    {
        public NYStylePizzaStore()
        {
        }
        protected override Pizza createPizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (item.Equals("veggie"))
            {
                return null;
            }
            else if (item.Equals("clam"))
            {
                return null;
            }
            else if (item.Equals("pepperoni"))
            {
                return null;
            }
            else
                return null;
        }
    }
}
