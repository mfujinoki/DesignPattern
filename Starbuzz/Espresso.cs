using System;
namespace Starbuzz 
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public double cost()
        {
            return 1.99;
        }
    }
}