using System;
namespace Starbuzz 
{
    public class Mocha : CondimentsDecorator
    {
        Beverage beverage;
        public Mocha (Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }
        public override double cost()
        {
            return .20 + beverage.cost();
        }
    }
}