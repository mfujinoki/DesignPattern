using System;
namespace Starbuzz 
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }
        public override double cost()
        {
            return .99;
        }
    }
}