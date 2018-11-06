using System;
namespace Starbuzz 
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public double cost()
        {
            return .89;
        }
    }
}