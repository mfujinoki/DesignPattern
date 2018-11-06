using System;
namespace Starbuzz 
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }
        public double cost()
        {
            return .99;
        }
    }
}