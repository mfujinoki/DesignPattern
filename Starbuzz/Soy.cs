using System;
namespace Starbuzz 
{
    public class Soy : CondimentsDecorator
    {
        Beverage beverage;
        public Soy (Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }
        public override double cost()
        {
            return .15 + beverage.cost();
        }
    }
}