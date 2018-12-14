using System;
namespace PizzaStore
{
    public class NYStyleCheesePizza:Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Margarita Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
