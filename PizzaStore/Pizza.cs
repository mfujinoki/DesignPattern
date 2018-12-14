using System;
using System.Collections;
namespace PizzaStore
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public ArrayList toppings = new ArrayList();
        public Pizza()
        {
        }
        public void prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough... ");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine(" " + toppings[i].ToString());
            }
        }
        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public string getName()
        {
            return name;
        }
    }
}
