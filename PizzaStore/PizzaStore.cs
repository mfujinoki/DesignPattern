using System;
namespace PizzaStore
{
    public abstract class PizzaStore
    {
        public PizzaStore()
        {
        }
        public Pizza orderPizza(string type)
        {
            Pizza pizza;
            pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
        protected abstract Pizza createPizza(string type);

    }
}
